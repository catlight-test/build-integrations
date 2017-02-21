if [ "$1" = "NUnit-CS-Success" ]; then
	mono ./testrunner/NUnit.ConsoleRunner.3.2.0/tools/nunit3-console.exe ./NUnit-CS-Success/bin/Debug/NUnit-CS-Success.exe
elif [ "$1" = "NUnit-CS-Partial"  ]; then
	mono ./testrunner/NUnit.ConsoleRunner.3.2.0/tools/nunit3-console.exe ./NUnit-CS-Partial/bin/Debug/NUnit-CS-Partial.exe
fi