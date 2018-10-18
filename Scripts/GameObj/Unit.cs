using System.Collections.Generic;

public class PropertyUnit
{
	string Name { get; set; }
	int Count { get; set; }
}

public class Unit : IAction
{
	List<PropertyUnit> propertys;

	public Unit()
	{
		propertys = new List<PropertyUnit>();
	}
	public void objAction()
	{
	}
}