using System;

public abstract class Bevarage
{
	protected string description = "Uknown bevarage";

	public virtual string Description => description;

	public abstract double Cost();
}
