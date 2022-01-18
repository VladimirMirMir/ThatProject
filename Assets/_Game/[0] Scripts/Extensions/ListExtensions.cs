using System.Collections.Generic;

public static class ListExtensions
{
    public static bool ContainsTypeWithID(this List<CreatureType> types, string id)
    {
        int result = 0;
        foreach (var creatureType in types)
            if (string.Equals(creatureType.creatureTypeID, id))
                result++;
        return result > 0;
    }
}