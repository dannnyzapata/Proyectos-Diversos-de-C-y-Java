#include <stdio.h>
#include <math.h>
#include <float.h>
#include <stdlib.h>
#include <string.h>
#define PI    3.141592654

int main(int argC, char *argV[]) {
	float angulo = 0;
	float rangulo = 0;
	float tangenteN = 0;
	float tangenteR = 0;
	
	for(;;){
	    printf("t?");
    	scanf("%f", &angulo);
    	fflush(stdin);   
	    if (angulo<0 || angulo >=90){    
	        printf("Entrada Incorrecta");
	        return 0; 
	    }else{
        	rangulo = angulo*(PI/180);
        	tangenteN = tan(rangulo);
	        tangenteR = sqrt((1-cos(2*rangulo))/(1+cos(2*rangulo)));
        	printf("a) tan %.2f = %.3f\n", angulo,tangenteR);	
	        printf("a) tan %.2f = %.3f\n", angulo,tangenteN);
	       
	    }
	}
	
return 0; 
}