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

int main(void)
{
    while(1)
	USART_Init(MYUBRR)
    {
        //TODO:: Please write your application code 
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