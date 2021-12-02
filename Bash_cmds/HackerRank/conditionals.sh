#!/usr/bin/bash

read x
#echo -e "YES\nNO\n" | grep -i $char
if [ $x == "Y" ] || [ $x == "y" ]
then 
    echo "YES"
elif [ $x == "N" ] || [ $x == "n" ]
then
    echo "NO"
fi