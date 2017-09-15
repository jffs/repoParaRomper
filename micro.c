#include <hidef.h> /* for EnableInterrupts macro */
#include "derivative.h" /* include peripheral declarations */

#ifdef __cplusplus
extern "C"
#endif
void MCU_init(void); /* Device initialization function declaration */
/*               >> 2 <- izquierda
  Orden de leds 1 3 4 7
                0 2 4 6
                -> Derecha << 2*/

unsigned short i;
char time;
int estado=0;
int cambio=0;
int izquierda;
int sec1; //1= secuencia 0-2-4-6-7-5-3-1
          //0= secuencia 0-1-3-5-7-6-4-2
void delay_ms(int time) {
    
    for (i = 0xFFFF; i > 0; i--)
        ;
    
}
void main(void) {
    MCU_init(); /* call Device Initialization */
    /* include your code here */
    PTBDD = 0XFF; //Configuración del PORTB como salida
    PTBD_PTBD0=1;
    PTCDD_PTCDD0=0; //pulsador como entrada
    PTCPE_PTCPE0=1; //pull-up
    izquierda=0;
    
    for (;;) {
        if (PTCD_PTCD0==0){
            for (time=0x0F;i>0;i--); // lo aprete
            while(!PTCD_PTCD0);	//sigo apretando
            for (time=0x0F;i>0;i--); //lo solte
            apreto=0;
            if (sec1==1) sec1=0;
            else sec1=1;
            switch (PTBD){
                case 0x40:
                    if (sec1==1){
                        PTBD=0x80;
                        izquierda=1;}
                    else PTBD=PTBD >> 2;
                break;
                    
                case 0x02:
                    if (sec1==1){
                        PTBD=0x01;
                        izquierda=0;}
                    else PTBD=PTBD << 2;
                break;
                
                case 0x80:
                    if (sec1==0){
                        PTBD=0x40;
                        derecha=0;}
                    else PTBD=PTBD >> 2;
                break;
                
                case 0x01:
                    if (sec1==0){
                        PTBD=0x02;
                        derecha=1;}
                    else PTBD=PTBD << 2;
                break;
                
                default:
                    if (sec1==1){
                            if (izquierda==0)
                                PTBD=PTBD << 2;
                            else
                                PTBD=PTBD >> 2;}
                    else
                        if (derecha==0)
                            PTBD=PTBD >> 2;
                        else
                            PTBD=PTBD << 2;
                break;
            }
            
            
        }
    }
}


