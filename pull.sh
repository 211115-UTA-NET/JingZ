#!/usr/bin/bash

git init
echo -n "Enter the branch you want to pull: "
read branch
git pull origin $branch