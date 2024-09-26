namespace SpaceMissionInventory
{
  class Program
  {
    public static void Main(string[] args)
    {
      string[] spaceInventory = ["Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools"];
      int[] itemQuantities = [10, 8, 15, 5, 6, 9, 4, 7];

      if (spaceInventory.Length == 8)
      {
        Console.WriteLine("Space Inventory is ready to go!");
      }
      else if (spaceInventory.Length > 8)
      {
        Console.WriteLine("Too many items!");
      }
      else if (spaceInventory.Length < 8)
      {
        Console.WriteLine("Add more items!");
      }
      //Print the second item of the spaceInventory array along with its quantity from the itemQuantities array
      Console.WriteLine($"The second item from spaceInventory array is {spaceInventory[1]} & it's quantity is {itemQuantities[1]}");

      //replace the last item in the spaceInventory with "Scientific Instruments"
      int indexOflastItemInInventoryArray = spaceInventory.Length-1;
      string lastItemInInventoryArray = spaceInventory[indexOflastItemInInventoryArray] = "Scientific Instruments";
      Console.WriteLine($"The last item in inventory array is: {lastItemInInventoryArray}");
      
      //update the quantity of the replaced "Scientific Instruments" item in the itemQuantities array to 5
      int scientificInstrumentIndex = Array.IndexOf(spaceInventory,"Scientific Instruments");
      int scientificInstrumentQtyIndex = itemQuantities [scientificInstrumentIndex] = 5;
      Console.WriteLine($"Updated quantity of Scientific Instruments is {scientificInstrumentQtyIndex}");

      //Print the first item with Quantity equal to 5
      string indexOfFirstItemWithQuantityFive;
      int indexOfQuantityFive = Array.IndexOf(itemQuantities,5);
      indexOfFirstItemWithQuantityFive = spaceInventory[indexOfQuantityFive];
      Console.WriteLine($"The first item with quantity 5 is {indexOfFirstItemWithQuantityFive}");

      //reverse the order of the items in the spaceInventory
      Array.Reverse(spaceInventory);
      Console.WriteLine($"The first item in reversed spaceInventory array is {spaceInventory[0]}");
      Console.WriteLine($"The last item in reversed spaceInventory array is {spaceInventory[^1]}");

      //sort the spaceInventory array alphabetically
      Array.Sort(spaceInventory);
      Console.WriteLine($"The first item in sorted spaceInventory array is {spaceInventory[0]}");
      Console.WriteLine($"The last item in sorted spaceInventory array is {spaceInventory[^1]}");

    }
  }
}