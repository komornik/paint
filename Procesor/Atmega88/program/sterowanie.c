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

int main(void)
{
	unsigned char c;
	USART_Init(MYUBRR)
    while(1)
    {
         c=USART_Receive(void);
		 USART_Transmit(c);
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
	while( !( UCSRnA & (1<<UDREn)) && );
	/*
	Put data into buffer, sends the data
	*/
	UDRn = data;
	
}

unsigned char USART_Receive(void)
{
	/*
	Wait for data to be received
	*/
	while
	( !(UCSRnA & (1<<RXCn)) )
	;
	/*
	Get and return received data from buffer
	*/
	return UDRn;
}