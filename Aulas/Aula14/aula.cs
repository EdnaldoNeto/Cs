using System;
using System.Globalization;
using Internal;

class Aula14{
    static void Main(){
        
        float  peso ,idade;

        Console.WriteLine("_________________Vamos fazer a dieta do seu filho!____________________\n\n");

        Console.WriteLine("Digite a idade do seu filho:\n");
        idade = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
        //Convertendo para float
        Console.WriteLine("Digite o peos do seu filho:\n");
        peso = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat); 
        //Convertendo para float

        if(idade <= 15){
            
            Console.WriteLine("\nCom base na idade: {0} e os kg: {1} do seu filho fizemos sua dieta:\n", idade, peso);

            if (idade <= 1) {
                if (peso <= 9) {
                    Console.WriteLine("Dieta: Leite materno ou fórmula + papinhas de frutas e\n legumes. 500-700 ml de leite/dia. Alimentos: 2-3 colheres\n de sopa de purê de frutas/legumes por refeição.\n\n");
                } else if (peso <= 11) {
                    Console.WriteLine("Dieta: Leite materno ou fórmula + 3 refeições de alimentos sólidos,\n 500-600 ml de leite/dia. Alimentos: 3-4 colheres de sopa de cereais, proteínas\n (frango, peixe) e frutas.");
                }
            } else if (idade <= 3) {
                if (peso <= 12) {
                    Console.WriteLine("Leite: 300-400 ml/dia + 3 refeições principais + 2 lanches (frutas, cereais).\n Incluir vegetais, frutas, proteínas (carne, peixe, ovo), leguminosas\n (feijão, lentilha).");
                } else if (peso <= 15) {
                    Console.WriteLine("Dieta: Leite: 300 ml/dia + refeições completas (frutas, legumes, proteínas) e \nlanches saudáveis (iogurte, frutas picadas, cereais integrais).");
                }
            } else if (idade <= 6) {
                if (peso <= 20) {
                    Console.WriteLine("Dieta: 3 refeições principais (arroz, feijão, carne, vegetais) + 2 lanches.\n Priorizar frutas, vegetais, grãos integrais, carnes magras e leguminosas.\n Evitar alimentos industrializados. Incluir 1-2 copos de leite/dia ou derivados.");
                } else if (peso <= 25) {
                    Console.WriteLine("Lanches saudáveis: frutas, biscoitos integrais, queijos. Refeições\n principais: proteínas (frango, peixe), carboidratos integrais \n(arroz integral, batata), vegetais.");
                }
            } else if (idade <= 9) {
                if (peso <= 30) {
                    Console.WriteLine("Café da manhã: Frutas, cereais integrais, leite. Almoço/jantar: Proteínas (carne, peixe, ovos), vegetais, grãos (arroz, macarrão). Lanches: Frutas, castanhas. Evitar doces.");
                } else if (peso <= 35) {
                    Console.WriteLine("Refeições completas: 3 principais + 2 lanches. Priorizar alimentos\n integrais, proteínas magras, grãos, frutas e vegetais. Evitar excesso de gorduras \nsaturadas e açúcares.");
                }
            } else if (idade <= 12) {
                if (peso <= 40) {
                    Console.WriteLine("Café da manhã: Pão integral, queijo magro, fruta. Almoço/jantar: Proteínas\n magras (frango, carne, peixe), carboidratos integrais, vegetais.\n Lanches: Frutas frescas, castanhas, iogurte. Ingestão de água ao longo do dia.");
                } else if (peso <= 45) {
                    Console.WriteLine("Refeições equilibradas: 3 principais + 2 lanches. Incluir mais fontes de cálcio\n (leite, iogurte), proteínas (ovos, frango), grãos integrais e frutas.\n Evitar alimentos ultraprocessados.");
                }
            } else if (idade <= 15) {
                if (peso <= 50) {
                    Console.WriteLine("Café da manhã: Fruta, cereal integral, leite. Almoço/jantar: Proteínas \n(carne, peixe, ovo), vegetais, carboidratos integrais (arroz, batata), leguminosas.\n Lanches: Iogurte, frutas, castanhas. Evitar fast food e refrigerantes.");
                } else if (peso <= 60) {
                    Console.WriteLine("Refeições balanceadas: 3 principais (proteínas, vegetais, carboidratos integrais)\n + 2 lanches (frutas, cereais integrais, iogurte). Aumentar o consumo de fibras \n(grãos integrais, vegetais) e cálcio.");
                }
            } 
        } else {
                Console.WriteLine("\nEstamos trabalhando cada vez, para melhorar este software... Aguarde updates");
        }
        Console.WriteLine("\n__________Obrigado por testar nosso software__________");
    }
}