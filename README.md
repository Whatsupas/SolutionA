# SolutionA
``
Exercise from Kattis testing system. Level - easy
``

## Issue 
While working on a new filesystem, KattisFS, Kattis has encountered the problem of fragmentation. A file is 
fragmented when it uses multiple disc blocks that are not contiguous (stored together in the same part of disk).
In her first implementation, the data got spread out over the disk, which makes access to the data very inefficient.
In addition, she has noticed that data stored close to the edge of the disk, where the rotation speed is higher, can
be accessed faster, and she wants to take advantage of this speed up access to high priority files.

Given the current layout of the data on a full disk, can you help her defragment the data, and reposition
the files with highest priority so they are stored where the disk is fastest?

## Input
The input contains of a most **100** disk maps. Each disk map uses several lines of text (between **1** and **100**) to show 
the mapping between files and disk blocks. Each line represents the disk blocks used by one file. Each disk can store up to
**80** blocks of data. A star (*) at line **i** and column **j** indicates that file **i** uses disk block **j**; otherwise
a period (.) indicates that the file is not using that block. A file may require zero blocks to store on disk, if it is empty.
The disk is guaranteed to be full, so each block is assigned to a file, and no block is assigned to multiple files.

Files are given in order of priority, with highest priority files first. Fastest access is to the right. Between each pair
of disk maps is a blank line, and the input ends at end of file.

## Output
Output a map of the disk, where the files are defragmented and displayed in priority order. Each file should be stored 
contiguously on the disk, with the highest priority files stored where the access speed is highest. Print a blank line
between each disk map. Do not print blank line after the last map.

## Sample  
```
Input                             Output 
...........*........              ...................*                                        
....*.....*.........              .................**.                                        
.........*..*...*...              ..............***...   
*..*..*......***....              ........******......
..*.....*...........              ......**............
.*..................              .....*..............
.................*.*              ..***...............
....................              ....................
......*...........*.              **..................

..........                       ..........   
.*.**.*...                       ......****
*....*.*.*                       ..****....
..........                       ..........
```
