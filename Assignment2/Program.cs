using Assignment2;


// Creating a nested structure

var structure = new Structure
{
    Value = 1,
    Children = new List<Structure>
      {
        new Structure
        {
          Value = 2,
           Children = new List<Structure>
           {
             new Structure { Value = 4 },
             new Structure { Value = 5 },
               new Structure
               {
                 Value = 6,
                  Children = new List<Structure>
                  {
                    new Structure { Value = 8 }
                  }
               }
           }
        },
       new Structure
       {
        Value = 3,
         Children = new List<Structure>
         {
          new Structure { Value = 7 }
         }
       }
    }
};


// Calculating the depth of the structure using recursion


int depth = CalculateDepth(structure);

Console.WriteLine("Depth of structure: " + depth);


int CalculateDepth(Structure structure)
{
    // If the structure has no children, its depth will be 1

    if (structure.Children == null || structure.Children.Count == 0)
    {
        return 1;
    }

    // Recursively calculating the depth of each child and returning the maximum depth

    int maxChildDepth = 0;
    foreach (var child in structure.Children)
    {
        int childDepth = CalculateDepth(child);
        if (childDepth > maxChildDepth)
        {
            maxChildDepth = childDepth;
        }
    }

    return maxChildDepth + 1;
}
