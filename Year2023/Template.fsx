#if INTERACTIVE 
#load "Utils.fsx"
open Utils
#else
module Year2023.DayXX
open Year2023.Utils
#endif

let puzzle = ("2023", "XX")
let example = getExample puzzle
let input = getInput puzzle

(****************************************************************************
 ********************************** Part 1 **********************************
 ****************************************************************************)

let runPart1 () = "IMPLEMENT ME"

(****************************************************************************
 ********************************** Part 2 **********************************
 ****************************************************************************)

let runPart2 () = "IMPLEMENT ME"

(****************************************************************************
 ********************************* Solution *********************************
 ****************************************************************************)

let solution =
    { part1 = runPart1
      part2 = runPart2 }

#if INTERACTIVE
printSol puzzle solution
#endif
