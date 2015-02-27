/*
 * GccApplication4.c
 *
 * Created: 2015-02-19 21:14:44
 *  Author: Krzysztof Simon
 */ 


#include <avr/io.h>

#define FOSC 2000000 // Clock Speed
#define BAUD 9600
#define MYUBRR FOSC/16/BAUD-1

void USART_Init(unsigned int ubrr);
void USART_Transmit(unsigned char data );
unsigned char USART_Receive(void);
void USART_Transmit_buff(const char *buff );

int main(void)
{
	unsigned char c;
	USART_Init(MYUBRR);
	USART_Transmit_buff("Witam podczas proby wysylania\n");
    while(1)
    {
         c=USART_Receive();
		 USART_Transmit(c);
		 USART_Transmit_buff("\n");
		 
    }
}


void USART_Init( unsigned int ubrr)
{
	/*Set baud rate */
	UBRR0H = (unsigned char)(ubrr>>8);
	UBRR0L = (unsigned char)ubrr;
	UCSR0B = (1<<RXEN0)|(1<<TXEN0);
	/* Set frame format: 8data, 1stop bit */
	UCSR0C = (0<<USBS0)|(3<<UCSZ00);
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