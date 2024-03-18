using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UIElements;

public class variaveis : MonoBehaviour
{
    //Objetos
    /*
    Vilao vilaoFase1;
    Vilao vilaoFase2;
    filha fi;
    */
    //metodos somar;
    //metodos obj;
    //pai p;
    //filho f;
    //calculadora calc;
    //Pai p;
    leao leo;
    gato gat;

    //string[] inimigos;
    //enum AI {Atacar=1,Correr,Patrulhar}
    // Start is called before the first frame update
    void Start()
    {
        // Laço for
        /*
          for (int i = 0; i <= 10; i++)
        {
            print(i);

            if (i == 5)
            {
                break;
            }
        }
        */

        // Laço while
        /*
        while (x <= 10) 
        {
            print(x++);
        }
        */

        // Laço do/while
        /*
        do
        {
            print(x);
            x++;
        } while (x <= 10);
        */

        //Laço foreach
        /*
        inimigos = new string[4];
        {
            inimigos[0] = "Imundo";
            inimigos[1] = "Azul";
            inimigos[2] = "Canalha";
            inimigos[3] = "Covarde";
        }

        foreach (string nomes in inimigos)
        {
            print (nomes);
            if (nomes == "Azul")
            {
                continue;
            }
            print (nomes);
        }
        */

        //Array Unidimensional(Vetor)
        /*
        int[] array = new int[10];

        for (int i = 0; i <= 9; i++)
        {
            array[i] = i + 1;

            print(i + " : " + array[i]);
        }
        */
        //Matrizes
        /*
        int[,] matriz = new int[2, 2];

        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;

        print(matriz[2, 2]);
        */

        //Matriz Simplificada
        /*
        int[,] matriz = new int[2, 2];
        int valor = 1;

        for (int linhas = 0; linhas <= 1; linhas++)
        {
            for (int colunas = 0; colunas <= 1; colunas++)
            {
                matriz[linhas, colunas] = valor;
                valor++;
                print(linhas + " : " + colunas + " = " + matriz[linhas, colunas]);
            }
        }
        */
        /*
        for (int linhas = 0; linhas <= 1; linhas++)
        {
            for (int colunas = 0; colunas <= 1; colunas++)
            {
                print(linhas + " : " + colunas + " = " + matriz[linhas, colunas]);
            }
        }
        */

        //Coleções
        //List
        /*
        List<int> lista = new List<int>();

        lista.Add(100);
        lista.Add(99);
        lista.Add(98);

        print(lista);
        */

        /*
        for (int i = 0; i <= 9; i++)
        {
            lista.Add(i);
            print(i);
        }
        */
        /*
        foreach (int valoes in lista)
        {
            print(valoes);
        }
        */

        //Dicionário
        /*
        Dictionary<string, string> vilao = new Dictionary<string, string>();

        vilao.Add("Vilao1", "É o primeiro vilão");
        vilao.Add("Vilao2", "É o segundo vilão");

        //Comando Remove
        vilao.Remove("Vilao1");

        foreach (string chave in vilao.Keys)
        {
            
            if(chave == "Vilao2")
            {
                print(vilao[chave]);
            }
            
        print(vilao[chave]);
        }
        */

        //Enumeradores
        /*
        AI vilaoFase1 = AI.Atacar;
        AI vilaoFase2 = AI.Correr;

        int v1 = (int)vilaoFase2;

        print(v1);
        */

        //Objetos e Modificadores de Acesso
        /*
        vilaoFase1 = new Vilao();
        vilaoFase2 = new Vilao();
        fi = new filha();

        vilaoFase1.nome = "Vilao1";
        vilaoFase1.forca = 100;
        vilaoFase1.atacar ();

        vilaoFase1.nome = "Vilao2";
        vilaoFase1.forca = 99;
        vilaoFase1.atacar();

        fi.acessa();
        */

        //Métodos
        /*
        int val;
        int val2;
        somar = new metodos();
        val = somar.soma(10, 2);
        val2 = somar.soma(-9, 2);
        //somar.soma(); //Retorno de resutlado sem a variável val

        print(val);
        print(val2);
        */

        //Construtores
        /*
        obj = new metodos(20, "Oi");

        print(obj.valor1);
        print(obj.valor2);
        */

        //Métedo Estático
        /*
        int retorno = metodos.soma(2, 5);
        print(retorno);
        */
        //This e Base
        /*
        p = new pai();
        //print(p.idade);

        f = new filho();
        f.pegaIdade();
        */

        //Sobrecarga de Método
        /*
        int resultINT;
        float resultFLOAT;

        calc = new calculadora();

        resultINT = calc.calcula(2, 5);
        resultFLOAT = calc.calcula(2.3f, 5.5f);

        print(resultINT);
        print(resultFLOAT);
        */

        //Encapsulamento
        /*
        p = new Pai();
        p.Idade = 22;

        //print(p.Idade);
        */
        //Polimorfismo

        leo = new leao();
        gat = new gato();

        leo.comer();
        gat.comer();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Estudo de Classes
    /*
    class Vilao : MonoBehaviour
        {
            //Características = Atributos
            public string nome;
            public int forca;

            //Ações = Métodos
            public void atacar()
            {
                nome = "A";
            }
        }
    */
    /*
    class filha : Vilao
        {
            public void acessa()
            {
                print(nome = "B");
            }
        }
    */

    //Métodos
    /*
    class metodos
        {
            public int soma(int valor1, int valor2) //O void foi alterando para int
            {
                int resultado = valor1 + valor2;

                return resultado;
            }
        }
    */

    //Construtores
    /*
    class metodos
        {
            public int valor1;
            public string valor2;


            public metodos()
            {
                valor1 = 10;
                valor2 = "Oi";
            }


            public metodos(int valor, string val)
            {
                this.valor1 = valor;
                this.valor2 = val;
            }
        }
    */

    //Método Estático
    // No modelo estático não é necessário criar objetos
    /*
    class metodos
        {
            public static int soma(int valor1, int valor2)
            {
                int resultado = valor1 + valor2;
                return resultado;
            }

            public int somar(int valor1, int valor2)
            {
                int resultado = valor1 + valor2;
                return resultado;
            }
        }
    */

    //This e Base
    /*
    class pai
        {
            public int idade = 22;
            public pai(int idade)
            {
                this.idade = idade;
            }
        }

    class filho : pai
        {
            public void pegaIdade()
            {
                print(base.idade);
            }
        }
    */

    //Sobrecarga de Método
    /*
    class calculadora
        {
            public int calcula(int x, int y)
            {
                return x + y;
            }

            public float calcula(float x, float y)
            {
                return x + y;
            }
        }
    */

    //Encapsulamento
    /*
    class Pai
        {
            private int idade = 10;

            public int Idade
            {
                get {  return idade; }
                set { if (idade > 10)
                        {
                            idade = value;
                        }
                        else 
                        {
                            print("ERROR");
                        } 
                    }
            }
        }
    */

    //Polimorfismo

    class animal
    {
        public virtual void comer()
        {
            print("O animal está comendo");
        }
    }

    class leao : animal
    {
        public override void comer()
        {
            print("O leão está comendo");
        }
    }

    class gato : animal
    {
        public override void comer()
        {
            print("O gato está comendo");
        }
    }

}
