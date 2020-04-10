#!/bin/bash
. bash/vars.sh

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

echo -e "\e[36m========== Building basic ==========\e[0m"
read -p "continue?"
build-one $1
