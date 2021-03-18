using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeldTest
{
    /// <summary>
    /// Um cara com Nome, idade e uma carteira cheia de dinheiro
    /// </summary>
    class Guy
    {
        /// <summary>
        /// Campo de Armazenamento de apenas leitura da Propriedade Name
        /// </summary>
        private readonly string name;

        /// <summary>
        /// O Nome do Cara
        /// </summary>
        public string Name { get { return name; } }

        /// <sumary>
        /// Campo de Armazenamento de apenas leitura para a Propriedade Age
        /// </sumary>
        private readonly int age;

        /// <summary>
        /// A idade do cara
        /// </summary>
        public int Age { get { return age; } }

        /*
         * Dinheiro não é readonly
         */
        /// <summary>
        /// O número de reais que o cara tem
        /// </summary>        
        public int Cash { get; private set; }

        /// <summary>
        /// O Construtor define o nome, idade e dinheiro
        /// </summary>
        /// <param name="name">O Nome do Cara</param>
        /// <param name="age">Idade do manino</param>
        /// <param name="cash">A quantidade de dinheiro que o cara começa</param>
        public Guy(string name, int age, int cash)
        {
            this.name = name;
            this.age = age;
            Cash = cash;
        }

        public override string ToString()
        {
            return String.Format("{0} is {1} years old and has {2} bucks", Name, Age, Cash);
        }

        /// <summary>
        /// Dar o dinheiro da minha carteira
        /// </summary>
        /// <param name="amount">Quantidade de dinheiro para entregar</param>
        /// <returns>A Quantidade dinheiro entregue, ou 0 se não tiver o suficiente</returns>
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0) 
            {
                Cash -= amount;
                return amount;
            }
            else
                return 0;
        }
        /// <summary>
        /// Receber algum dinheiro em minha carteira
        /// </summary>
        /// <param name="amount">Quantidade a receber</param>
        /// <returns>Quantidade recebida ou 0 se nenhum dinheiro for recebido</returns>
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            Console.WriteLine("{0} says: {1} isn't amount I'll take", Name, amount);
            return 0;
        }
    }

    class GuyCollection : IEnumerable<Guy>
    {
        private static readonly Dictionary<string, int> namesAndAges = new Dictionary<string, int>()
        {
            {"Joe", 41}, {"Bob", 43}, {"Ed", 39}, {"Larry", 44}, {"Fred", 45}
        };

        public IEnumerator<Guy> GetEnumerator()
        {
            Random random = new Random();
            int pileOfCash = 125 * namesAndAges.Count;
            int count = 0;
            foreach (string name in namesAndAges.Keys)
            {
                int cashForGuy = (++count < namesAndAges.Count) ? random.Next(125) : pileOfCash;
                pileOfCash -= cashForGuy;
                yield return new Guy(name, namesAndAges[name], cashForGuy);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Obter ou definir a idade de certo cara
        /// </summary>
        /// <param name="name">Nome do Cara</param>
        /// <returns>Idade do Cara</returns>
        public int this[string name]
        {
            get
            {
                if (namesAndAges.ContainsKey(name))
                    return namesAndAges[name];
                throw new IndexOutOfRangeException("Name " + name + " was not found");
            }
            set
            {
                if (namesAndAges.ContainsKey(name))
                    namesAndAges[name] = value;
                else
                    namesAndAges.Add(name, value);
            }
        }
    }

    class GuyCollection2 : IEnumerable<Guy>
    {
        private static readonly Dictionary<int, Guy> idsAndGuys = new Dictionary<int, Guy>()
        {
            {1, new Guy("Joe", 41, 755)},
            {2, new Guy("Bob", 43, 132)}, 
            {3, new Guy("Ed", 39, 71)}, 
            {4, new Guy("Larry", 44, 1645)}, 
            {5, new Guy("Fred", 45, 2131)}
        };

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Guy> GetEnumerator()
        {
            foreach (int id in idsAndGuys.Keys)
            {
                yield return idsAndGuys[id];
            }
        }

        public Guy this[int index]
        {
            get { return idsAndGuys[index]; }
            set 
            {
                if (idsAndGuys.ContainsKey(index))
                    idsAndGuys[index] = value;
                else
                    idsAndGuys.Add(index, value);           
            }
        }
        public Guy this[string name]
        {
            get
            {
                foreach (Guy tempGuy in idsAndGuys.Values)
                {
                    if (tempGuy.Name == name)
                        return tempGuy;                  
                }
                throw new IndexOutOfRangeException("Name " + name + " was not found");
            }
            set
            {
                for (int i = 0; i < idsAndGuys.Count; i++)
                {
                    if (idsAndGuys.ContainsKey(i)) 
                    {
                        Guy tempGuy = idsAndGuys[i];
                        if (tempGuy.Name == name)
                        {
                            idsAndGuys[i] = value;
                            return;
                        }
                    }
                }
                int index = idsAndGuys.Count + 1;
                idsAndGuys.Add(index, value);  
            }
        }
    }
}
