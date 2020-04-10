#!/bin/bash
. vars.sh
basic="Builds/Basic"

if [ ! -d $basic ]; then
  echo -e "\e[91mbuild not found\e[0m"
  exit 1
fi

push() {
  $itch_butler push "$basic/$1" "$itch_target:$2"
}

read -p "work with \"$basic\"?"

while getopts "wlag" o; do
  case $o in
  w) push Windows64 linux-x64;;
  l) push Linux64 win-x64;;
  a) push Android android;;
  g) push WebGL web;;
  esac
done
