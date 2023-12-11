/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pratica01;

import javax.swing.JOptionPane;

/**
 *
 * @author Manhã
 */
public class Pratica01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        //EXERCICIO 1//
        
        System.out.println("EXERCICIO 1");
        System.out.println("Fazer um programa que imprime os números de 1 a 5 na tela.");
        
        for (int i = 0; i < 5; i++) {
            System.out.println(i);
        }
      
       //EXERCICIO 2//
       
        System.out.println("\n\nEXERCICIO 2");
        System.out.println("Fazer um programa que imprime os números de 1 a 5 na tela. Usando while(teste){ instruções do bloco } ");
      
    int cont=0;
    
    while(cont < 6) 
    {
        System.out.println(cont);
        
        cont++;
    }
    
    
        System.out.println("\n\nEXERCICIO 3");
        System.out.println("Fazer um programa que imprime os números de 1 a 5 na tela. Usando do { instruções do bloco }while( teste );");
        
        int j=0;
        
        do {
            System.out.println(j);
            j++;
            
        } while (j<6);
        
        System.out.println("\n\nEXERCICIO 4");
        System.out.println("Fazer um programa que imprime os números pares que existemno intervalo entre 1 e 15.");
        
        for (int k = 0; k < 15; k++) {
            
            if (k%2==0) {
                System.out.println(k);
            }
        }
                
          System.out.println("\n\nEXERCICIO 5");
          System.out.println("Fazer um programa que imprime na tela o somatório dos números entre 0 e 10.");
          
          
          int soma =0;
          
         for (int z = 0; z < 10; z++) {
            
            soma=soma+z;
            
        }
          System.out.println(soma);
          
          System.out.println("\n\nEXERCICIO 6");
          System.out.println("Fazer um programa que imprime na tela a média dos números ímpares que estão no intervalo entre 0 e 100.");
          
          int somaImpar=0;
           
          for (int i = 0; i < 100; i++) {
            
              if (i%2==1) {
                  somaImpar=somaImpar+i;
              }
        }
          System.out.println("A soma dos impares são:" + somaImpar);
          System.out.println("A média dos numeros impares é: " + (somaImpar/3));
          
          System.out.println("\n\nEXERCICIO 7"
                  + "\n Fazer um programa que exibe uma janela de diálogo para o usuário entrar com um nome e após isso o programa imprime este nome na tela de saída, mas somente se o usuário fornecer um nome.");
          
          String nome=JOptionPane.showInputDialog("Insira seu nome");
          
          if (nome.equals("") == true) {
            
              JOptionPane.showMessageDialog(null, "NOME NÃO INSERIDO");
              
              
             
         }else{
              if (nome.equals(nome) == true) {
                  StringBuilder sb=new StringBuilder();
                  sb.append("NOME: " );
                  sb.append(nome);
                 JOptionPane.showMessageDialog(null, sb.toString());
          
              }
          
          }
          
          System.out.println("\nEXERCICIO 8"
                  + "\nFazer um programa que exibe uma janela de diálogo para o usuário entrar com um número inteiroe após isso o programa imprime na tela amensagem dizendo que o número é par ou ímpar.");
          String n1=JOptionPane.showInputDialog("Insira um numero");
          int numero=Integer.parseInt(n1);
          
          if (numero%2==0) {
            StringBuilder sb=new StringBuilder();
                  sb.append("O numero é par : " );
                  sb.append(numero);
                 JOptionPane.showMessageDialog(null, sb.toString());
        }else{
          StringBuilder sb=new StringBuilder();
                  sb.append("O numero é Impar : " );
                  sb.append(numero);
                 JOptionPane.showMessageDialog(null, sb.toString());
          }
          
          
    }
    
   
    
  


    
}
