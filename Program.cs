using System;

namespace L6Hash
{

    class HashItem {
        public string _value;
        public string _name;
        public bool _deleted;

        // HashItem constructor - initialise each attribute
        public HashItem () {
            _value = null;
            _name = null;
            _deleted = false;
  
        }
  }
  class HashTable {
    HashItem [] _hashTable;
    int hashSize;   // Size of hash table

    public HashTable (int size = 100) {
      hashSize = size;

      // Allocate the hash table from the heap. 
      // The table is an array of HashItem object references
      _hashTable = new HashItem [size];   // the hash table

      // For each reference in the hash table, link it to a newly
      // constructed HashItem
      for (int i = 0; i < _hashTable.Length; i++)
        _hashTable[i] = new HashItem();
    }

    public int HashFunction (string name) {
      
      // You need to implement a proper HashFucntion here!
      Console.WriteLine ("HashFunction() returns 0");
      return 0;
    }

    // Add item to hash table
    public void Add (string name, string value) {
      
      // Get the start index into the hash table
      int i = HashFunction (name);

      // Debug for the current index
      // TODO: This code does not deal with collision!
        
      //if (_hashTable[i]._name == null)
        //Console.WriteLine ("Empty hash");
      //else
        //Console.WriteLine ("Full hash");

      // Enter the name, value pair in the hash table
      _hashTable[i]._name = name;
      _hashTable[i]._value = value;
      Console.WriteLine ("Added ({0}, {1}) in slot {2}", name, value, i);
    }
    
    // Print out debug and load factor information about the hash table
    public void PrintInfo() {
        Console.WriteLine ("TODO: Implement PrintInfo()");
    }
  }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the hash table
            HashTable h = new HashTable (53);

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            // Add the data into the hash table
            for (int i = 0; i < months.Length; i++)
                h.Add (months[i], (i+1).ToString());

            // Print the stats in the hash table
    
            h.PrintInfo();

            // Add more data to generate collisions
    
            // Loop to find data in the hash table

            // Extension 1: Delete an item from the hash table

            // Extension 2: Rehash the table
    }
}
