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
    echo -n "Create a file name: "
	read filename
	filepath=./$foldername/$filename
	if [ -f $filepath ]
	then
		echo "file already exists!"
	else
		touch $filepath
		# write contents
		echo -n "write a line to file: "
		read line
		echo $line > $filepath
		# old numbers
		for (( i=1; i<20; i+=2 ))
		do
			echo $i >> $filepath
		done
		# use -n to input even numbers in the same line
		for (( i=2; i<=20; i+=2 ))
		do
			even+=$i
			if [ $i -lt 20 ]; then
				even+=", "
			fi
		done
		echo -n $even >> $filepath
		# show contents
		echo "[Preview of $filename:]"
		cat $filepath
	fi
	
elif [ $x == "N" ] || [ $x == "n" ]
then
    echo "Bye!"
fi
