using Aoc2022;
using System.Diagnostics;

class Program
{

	static void Main(string[] args)
	{
		AocDay day;
		if ((args.Length == 1) && (Enum.TryParse(args[0], out day)))
		{
			var sampleData = AocInputDataFactory.ReadInputData(day, InputDataType.Sample);
			var actualData = AocInputDataFactory.ReadInputData(day, InputDataType.Data);

			// Part 1
			Console.WriteLine("\n~~~** Part 1 **~~~");
			(int result, Int64 timeElapsed) solution = Solve(sampleData, AocPart.Part1);
			Console.WriteLine($"Solution to Part 1 - Sample - is {solution.result}  \n\t Time elapsed : {solution.timeElapsed}");
			solution = Solve(actualData, AocPart.Part1);
			Console.WriteLine($"Solution to Part 1 - Sample - is {solution.result}  \n\t Time elapsed : {solution.timeElapsed}");

			// Part 2
			Console.WriteLine("\n~~~** Part 2 **~~~");
			solution = Solve(sampleData, AocPart.Part2);
			Console.WriteLine($"Solution to Part 2 - Sample - is {solution.result}  \n\t Time elapsed : {solution.timeElapsed}");
			solution = Solve(actualData, AocPart.Part2);
			Console.WriteLine($"Solution to Part 2 - Sample - is {solution.result}  \n\t Time elapsed : {solution.timeElapsed}");
		}
		else
		{
			throw new InvalidProgramException("Incorrect argument passed to Main function. Arguments must be one of - Day00, Day01... , Day25");
		}
	}

	static (int result, Int64 timeElapsed) Solve(IInputData data, AocPart part)
	{
		Int32 result;
		Int64 timeElapsed;
		Stopwatch sw = new Stopwatch();
		sw.Start();
		switch (part)
		{
			case (AocPart.Part1):
				result = data.SolutionToPart1;
				break;
			case (AocPart.Part2):
				result = data.SolutionToPart2;
				break;
			default:
				throw new ArgumentException("Invalid argument for AocPart.");
		}
		sw.Stop();
		timeElapsed = sw.ElapsedMilliseconds;

		return (result, timeElapsed);
	}

}
