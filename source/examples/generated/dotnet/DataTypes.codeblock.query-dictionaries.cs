// Find all Inventory items that have "Petunia"
// as a key in their PlantDict.
var petunias = realm.All<Inventory>()
    .Filter("PlantDict.@keys == 'Petunia'");

// Find all Inventory items that have at least one value in their
// IntDict that is larger than 5
var matchesMoreThanFive = realm.All<Inventory>()
    .Filter("NullableIntDict.@values > 5");

// Find all Inventory items where any RequiredStringsDict has a key
// "Foo", and the value of that key contains the phrase "bar"
// (case insensitive)
var matches = realm.All<Inventory>().Filter("RequiredStringsDict['foo'] CONTAINS[c] 'bar'");


