#!/usr/bin/bash

read x
read y
sum=$((x + y))
sub=$((x - y))
mul=$((x * y))
div=$((x / y))
echo -e "$sum\n$sub\n$mul\n$div"  #!use -e to able to access \n