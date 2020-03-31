#include <stdio.h>
#include <math.h>
#include <float.h>
#include <locale.h>
#include <stdlib.h>

int main(void)
{
    
int i;
double a[4];
float u = 0.0, G = 32767, A,  k;
setlocale (LC_ALL, "");

for(int i = 0; i<4;i++){
printf("Dale valor a a%i ", i+1);
scanf("%lf",&a[i]);
	
}

A = a[0];

for(i = 0; i<=4;i++){
	if(a[i]<0 && a[i]<G){	
	G=a[i];
	    
	}
	
}
G = fabs(G);

double temp;
for(i = 0; i<4;i++){
	if(a[i]<0){
		temp = a[i];
		goto next;
	}		
}

next: 
if (temp == a[0]){
	k=0;
}

if (temp == a[1]){
	k=1;
}

if (temp == a[2]){
	k=2;
}

if (temp == a[3]){
	k=3;
}

u = 1 + pow((G/A),(1/k));
printf( "\nEl valor de la cota superior del polinomio es: %.1f", u );

        return 0;
}
