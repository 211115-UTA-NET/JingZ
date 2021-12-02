#!/usr/bin/bash

a=(1 2 3 4 5 6 7)
i=1
unset a[1]
unset a[i+1]
a=("${a[@]}")

for x in "${!a[@]}"
do
	echo "idx = $x"
	echo "${a[$x]}"
done

echo "size = ${#a[@]}"

# echo "idx 5 = ${a[5]}"

i=0
while [ ${#a[@]} != 0 ]
do
	unset a[i]
	echo "${a[@]}"
	((i++))
done
