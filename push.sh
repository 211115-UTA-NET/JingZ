#!/usr/bin/bash

echo -n "You want to push: "
read input
git init
git add $input
git status
echo -n "Commit message: "
read msg
git commit -m '$msg'
echo -n "push branch name: "
read branch
git push origin $branch