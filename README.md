# Name-Sorter
This is a simple .Net console application that reads a list of names from a text file, sorts them, and then writes the sorted names to another text file. It sorts the names alphabetically by last name, and in the case of identical last names, it sorts them by given names.

## Getting Started

To run this application, follow these steps:

1. Clone this repository to your local machine.
2. Navigate to the `Name-Sorter` directory.
3. Open the solution file (`Name-Sorter.sln`) in your preferred IDE.
4. Build the solution.
5. Open a terminal or command prompt.
6. Navigate to the `Name-Sorter\Name-Sorter\bin\Debug\net8.0` directory.
7. Run the application with the following command:
   `name-sorter <file-path>`
   Replace `<file-path>` with the path to the input text file containing the unsorted names.

## Usage
The application takes one argument: the path to the input text file containing the unsorted names.

#### Sample run

Run the name-sorter application by passing the file-path to the file "unsorted-names-list.txt" as argument which contains the list of unsorted names as follows:

<img src="https://github.com/arunmakattil/Name-Sorter/assets/138980990/f5563fc5-2318-4fb5-bd4d-364bf2f68288" alt="Example 1" width="300"/>

Execution output: Once the program is executed, it will create a text file with the sorted names list and also display the sorted names in the console.

<img src="https://github.com/arunmakattil/Name-Sorter/assets/138980990/034fcb43-e93b-4f32-abaa-371a083f5ef7" alt="Example 2" width="700"/>

## Assumptions

- All names will contain at least one given name and one last name.
- If a name contains only one part, it is assumed to be a given name.
- For names with multiple given names, they will be considered as part of the given name and sorted accordingly.

#### Example:

If the following list of names is provided:

![Unsorted Names](https://github.com/arunmakattil/Name-Sorter/assets/138980990/0d18cab6-5a89-468b-a5d0-8dd629514e75)

The sorted names will be:

![Sorted Names](https://github.com/arunmakattil/Name-Sorter/assets/138980990/317d3ee0-ed16-4019-8b2d-9a53d0522f37)


## Continuous Integration
Continuous Integration (CI) is set up using AppVeyor. Whenever changes are pushed to the development or master branch in the repository, AppVeyor automatically builds and runs the tests to ensure the integrity of the codebase.
<img src="https://github.com/arunmakattil/Name-Sorter/assets/138980990/77537326-3ece-4ed1-8b53-049c0cd43eff" alt="Example 5" width="700"/>

