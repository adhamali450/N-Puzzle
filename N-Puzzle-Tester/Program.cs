using N_Puzzle_Solver;
using System.Diagnostics;

const string TEST_CASES_DIRECTORY = "../../../Testcases",
            SAMPLE_SOLVABLES = TEST_CASES_DIRECTORY + "/Sample/Solvable puzzles/",
            SAMPLE_UNSOLVABLES = TEST_CASES_DIRECTORY + "/Sample/Unsolvable Puzzles/",

            COMPLETE_SOLVABLES_MH = TEST_CASES_DIRECTORY + "/Complete/Solvable Puzzles/Manhattan & Hamming/",
            COMPLETE_SOLVABLES_M = TEST_CASES_DIRECTORY + "/Complete/Solvable Puzzles/Manhattan Only/",
            COMPLETE_UNSOLVABLES = TEST_CASES_DIRECTORY + "/Complete/Unsolvable Puzzles/",

            V_LARGE = TEST_CASES_DIRECTORY + "/Complete/V. Large test case/TEST.txt";

string[] files = Directory.GetFiles(COMPLETE_SOLVABLES_M);

Console.WriteLine("============ V_LARGE ============");

Stopwatch watch = new Stopwatch();
watch.Start();

var state = Utils.FetchPuzzle(files[3], HeuristicFunction.ManhattenDistance);

Solver.PrioritySolve(ref state);

watch.Stop();

Console.WriteLine($"#Levels: {state.GScore}");
Console.WriteLine($"Elapsed time: {Math.Ceiling((double)watch.ElapsedMilliseconds / 1000)}sec");
Console.WriteLine("-------------");

Console.Read();