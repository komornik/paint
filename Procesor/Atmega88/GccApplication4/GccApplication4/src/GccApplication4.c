/*
 * GccApplication4.c
 *
 * Created: 2015-02-19 21:14:44
 *  Author: Krzysztof Simon
 */ 


#include <avr\io.h>
#include <util\delay.h>

#define FOSC 1000000
#define F_CPU 1000000
#define BAUD 2400
#define MYUBRR FOSC/16/BAUD-1
#define ZAW0 (1<<PB0)
#define ZAW1 (1<<PB1)
#define T_WOD 200
#define T_POW 10
#define T_KON_LINE 100
#define T_KON_WYSW 200
#define PRZERWA 1000

void USART_Init(unsigned int ubrr);
void USART_Transmit(unsigned char data );
unsigned char USART_Receive(void);
void USART_Transmit_buff(const char *buff );

int main(void)
{
	char koniec = 0;
	char c;
	DDRB |= ZAW0 | ZAW1;
	PORTB |= ZAW0| ZAW1;
	USART_Init(MYUBRR);
	_delay_ms(PRZERWA);
	PORTB ^= ZAW0| ZAW1;
	

   while(1)
    {
		c=USART_Receive();
		switch(c)
		 {
			 
			 case '0' :
				// wyswietlenie pikselu 0
				PORTB |= ZAW0;
				_delay_ms(T_WOD);
				PORTB ^=ZAW0;
				_delay_ms(PRZERWA);
				USART_Transmit(c);
				break;
			 
			case '1' :
				// wyswietlenie pikselu 1
				PORTB |= ZAW1;
				_delay_ms(T_POW);
				PORTB ^=ZAW1;
				_delay_ms(PRZERWA);
				USART_Transmit(c);
				break;
			case 0 :
				// obsluga w momecie naciœniecie przycisku Anuluj w programie oraz zakoñczenie wysy³ania zdjêcia
				PORTB |= ZAW1;
				_delay_ms(T_KON_WYSW);
				PORTB ^=ZAW1;
				_delay_ms(PRZERWA);
				USART_Transmit(c);
				break;
			case 3:
				// obsluga konca lini
				PORTB |= ZAW1;
				_delay_ms(T_KON_LINE);
				PORTB ^=ZAW1;
				_delay_ms(PRZERWA);
				USART_Transmit(c);
				break;
			 
			 default : 
				USART_Transmit_buff("sterowanie zawotrami za pomoca 0 i 1");
			 
			 
			 
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