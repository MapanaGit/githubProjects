/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author GNSE
 */
public class calc {
    public static void main(String[] args){
         //calculate min and max temperrature and 
         //determine average
        
         int temp1=7,temp2=30,temp3=45,temp4=10,min,max,avg;
         min=temp3-temp2;
         System.out.println("Minimum temperature is: "+ min);
         max=temp3;
         System.out.println("Maximun temperature is: "+ max);
         
         //average
         avg=(temp1+temp2+temp3+temp4)/4;
         System.out.println("Avarage temperature is: "+ avg);
    }
}
