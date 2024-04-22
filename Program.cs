using Uncle_s_Pay;

Uncle Francis = new Uncle {
	Name = "mugume Francis",
	NumberOfKids = 2
};

Kids Pearl = new Kids
{
	Name = "Pearl Amara",
	SchoolFees = 200000
};
	Kids Eboku = new Kids
	{
		Name = "Eboku collins",
		SchoolFees = 250000
	};
	Francis.CalculateFees(Pearl.SchoolFees, Eboku.SchoolFees);


