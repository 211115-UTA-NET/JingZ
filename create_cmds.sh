#!/usr/bin/bash

echo -n "Create a folder name: "
read foldername

if [ -d "./$foldername" ]
then 
	echo "folder already exists!"
else
	mkdir $foldername
fi

echo -n "Do you want to create a file in the folder? (y/n) "
read x
if [ $x == "Y" ] || [ $x == "y" ]
then 
    echo -n "Create a file name"
	read filename
	filepath="./$foldername/$filename"
	if [ -f $filepath ]
	then
		echo "file already exists!"
	else
		touch $filepath
		
		#! write contents
		echo "write a line to file"
		read line
		#! old numbers
		echo $line > $filepath
		for (( i=1; i<20; i+=2 ))
		do
			echo $i >> $filepath
		done
		#! use -n to input even numbers in the same line
		for (( i=2; i<20; i+=2 ))
		do
			echo -n "$i " >> $filepath
		done
		#! show contents
		cat $filepath
	fi
	
elif [ $x == "N" ] || [ $x == "n" ]
then
    echo "Bye!"
fi
