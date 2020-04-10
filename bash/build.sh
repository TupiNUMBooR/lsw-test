#!/bin/bash
. vars.sh

if [ -z $1 ]; then
  echo -e "\e[91mmust specify build method - Default or PC\e[0m"
  exit 1
fi

build-one() {
  tail -F ~/.config/unity3d/Editor.log &
  tp=$(echo "$!")
  
  $unity_editor -quit -batchmode -nographics -executeMethod Editor.Builder.Build$1
  
  kill $tp
}

git status
#[ ! -z "$(git status --porcelain)" ] && exit 1
#TODO stash

echo -e "\e[36m========== Building basic ==========\e[0m"
read -p "continue?"
git checkout master
build-one $1

echo -e "\e[36m========== Building steam ==========\e[0m"
echo "Did you read README.md on steam branch?"
read -p "continue?"
git checkout steam
build-one $1

git checkout master