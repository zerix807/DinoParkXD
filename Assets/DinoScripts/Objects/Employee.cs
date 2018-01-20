using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee {
	public string profession;

	public class Vet : Employee
	{
		public Vet() : base("Vet")
		{
			
		}
	}

	public class Keeper : Employee
	{
		public Keeper() : base("Keeper")
		{

		}
	}

	public class Maintenance : Employee
	{
		public Maintenance() : base("Maintenance")
		{

		}
	}

	public class TourGuide : Employee
	{
		public TourGuide() : base("Tour Guide")
		{

		}
	}

	public class Janitor : Employee
	{
		public Janitor() : base("Janitor")
		{

		}
	}

	public class SecurityGuard : Employee
	{
		public SecurityGuard() : base("Security Guard")
		{

		}
	}

	public Employee(string pro) {
		profession = pro;
	}

}
