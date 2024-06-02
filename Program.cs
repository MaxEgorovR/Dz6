using System.Collections;

ArrayList builders = new ArrayList();
builders.Add(new Builder { YearOfConstruction = 1997, NumberOfOffices = 10, Area = 1000 });
builders.Add(new Builder { YearOfConstruction = 1990, NumberOfOffices = 12, Area = 900 });
builders.Add(new Builder { YearOfConstruction = 2001, NumberOfOffices = 4, Area = 2000 });
for(int i = 0; i < 3; i++)
{
    Console.WriteLine(builders[i].ToString() + "\n");
}
builders.Sort(new SortOfficceBuilderComparer());
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(builders[i].ToString() + "\n");
}
builders.Sort(new SortOfficceBuilderComparer());
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(builders[i].ToString() + "\n");
}
builders.Sort(new SortAreaBuilderComparer());
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(builders[i].ToString() + "\n");
}

class Builder : IComparable
{
    public int YearOfConstruction {  get; set; }

    public int NumberOfOffices { get; set; }

    public double Area {  get; set; }

    public int CompareTo(object? obj)
    {
        return YearOfConstruction.CompareTo(obj);
    }

    public override string ToString()
    {
        return $"Year of constraction {YearOfConstruction}\nNumber of offices {NumberOfOffices}\nArea {Area}\n";
    }
}

class SortOfficceBuilderComparer : Builder, IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Builder && y is Builder)
        {
            if ((x as Builder).NumberOfOffices > (y as Builder).NumberOfOffices)
            {
                return 1;
            }
            else if ((x as Builder).NumberOfOffices < (y as Builder).NumberOfOffices)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        throw new NotImplementedException();
    }
}

class SortAreaBuilderComparer : Builder, IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Builder && y is Builder)
        {
            if ((x as Builder).Area > (y as Builder).Area)
            {
                return 1;
            }
            else if ((x as Builder).Area < (y as Builder).Area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        throw new NotImplementedException();
    }
}