/*
 * GccApplication4.c
 *
 * Created: 2015-02-19 21:14:44
 *  Author: Krzysztof Simon
 */ 


#include <avr/io.h>
#include <util\delay.h>

#define FOSC 1000000
#define BAUD 2400
#define MYUBRR FOSC/16/BAUD-1
#define ZAW0 PB0
#define ZAW1 PB1

void USART_Init(unsigned int ubrr);
void USART_Transmit(unsigned char data );
unsigned char USART_Receive(void);
void USART_Transmit_buff(const char *buff );

int main(void)
{
	DDRB |= (1<< ZAW0) | (1<<ZAW1);
	PORTB |= (1<<ZAW0);
	unsigned char c='a';
	USART_Init(MYUBRR);
	_delay_ms(1000);
	
	PORTB ^=(1<<LED);
   while(1)
    {
		c=USART_Receive();
		 switch(c)
		 {
			 case '0'       :
				PORTB |= (1<<ZAW0);
				_delay_ms(1000);
				PORTB ^=(1<< ZAW0);
				udi_cdc_write_buf("START \n\r", 14);
			 break;// USTAWIENIE 0 I 1
			 
			 case '1'       :
				PORTB |= (1<<ZAW1);
				_delay_ms(1000);
				PORTB ^=(1<< ZAW1);
				break;
			 
			 default        : 
				USART_Transmit_buff("sterowanie zawotrami zapomoca 0 i 1")
			 
			 
			 
		 };
		 
		 
    }
}


void USART_Init( unsigned int ubrr)
{
	/*Set baud rate */
	UBRR0H = (unsigned char)(ubrr>>8);
	UBRR0L = (unsigned char)ubrr;
	UCSR0B = (1<<RXEN0)|(1<<TXEN0);
	/* Set frame format: 8data, 1stop bit */
	UCSR0C = (1<<USBS0)|(3<<UCSZ00);
}

void USART_Transmit(unsigned char data )
{
	/*
	Wait for empty transmit buffer
	*/
	while( !( UCSR0A & (1<<UDRE0)));
	/*
	Put data into buffer, sends the data
	*/
	UDR0 = data;
}

void USART_Transmit_buff(const char *buff ){
	
	while(*(buff)){
	USART_Transmit(*(buff));
	buff++;	
	}
	
}

unsigned char USART_Receive(void)
{
	/*
	Wait for data to be received
	*/
	while
	( !(UCSR0A & (1<<RXC0)) );
	/*
	Get and return received data from buffer
	*/
	return UDR0;
}