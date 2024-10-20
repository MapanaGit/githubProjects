import java.util.*;
import java.util.Scanner;

public class annual_report {
    public static void main(String[] args){
        //call scanner library
        Scanner input = new Scanner(System.in);
        //the program prints annual report 
        double electricityandwater,insurance,advertising,rental,
                maintenance,telephone,salaries,sales,cost_of_sales,
                gross_profit,stationary,investment,transport_cost,
                audit_fees,commision_fees,other_income,operating_income;
        //sales
        sales=800000;
        cost_of_sales=250000;
       
        //determine gross profit
        //income
        rental=3500;
        commision_fees=150;
        other_income=6500;
        
        //expense
        audit_fees=2500; stationary=3000;electricityandwater=750;
        telephone=150;advertising=100;salaries=10000;
        insurance=600;investment=6000;transport_cost=1000;
        maintenance=1500;
        
//gross profit
//prompt a user to enter some figures

        gross_profit=(sales-cost_of_sales);
        System.out.println("Gross profit R"+ gross_profit);
        //operating income
        System.out.println("Other operating income R"+ gross_profit
        +other_income);
        System.out.println("Total income R"+ rental + commision_fees + 
                other_income + gross_profit);
        
        System.out.println();
        System.out.println("Operating expenses:");
        System.out.println("Audit fees: R"+ audit_fees);
        System.out.println("Stationary: R"+ stationary);
        System.out.println("Electricity & water: R"+ electricityandwater);
        System.out.println("Telephone: R"+ telephone);
        System.out.println("Advertising: R"+ advertising);
        System.out.println("Salaries: R"+ salaries);
        System.out.println("Insurance: R"+ insurance);
        System.out.println("Investment: R"+ investment);
        System.out.println("Transport cost: R"+ transport_cost);
        System.out.println("Maintenance: R"+ maintenance);
        double total_expenses,total_income;
        total_income=(rental+other_income+commision_fees+gross_profit);
        total_expenses=(audit_fees+stationary+electricityandwater+
                telephone+advertising+salaries+insurance+investment+
                transport_cost+maintenance);
        double net_income;
        net_income=(total_income-total_expenses);
        System.out.println("Net Income: R"+ net_income);
        System.out.println("************done**************");
        //determine if you have made profit or loss
        if(total_income<total_expenses){
            System.out.println("You have made loss");
        }else{
            System.out.println("You have made profit");
        }
    }
}
