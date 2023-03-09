# Headpose
Acquire live video feed from webcam and perform head pose estimation on user. Outputs yaw and pitch angle in C#.

Make sure to have the following environment configured before running your codes:

For Python:

ver 3.80 or below (you can create a virtual environment for this and add it to your anaconda environment, I use python 3.8.12) The following version of the libraries need to be installed (remember to install it under the virtual environment)

#create environment conda create --name myenv python=3.8.12 conda activate myenv

#install TensorFlow conda install tensorflow=2.3.0

#install opencv conda install opencv=4.0.1

#install mediapipe pip install mediapipe==0.8.9.1

#install spyder pip install spyder

#add the virtual environment to youe anaconda environment list after installing all the above library conda config --add envs_dirs C:\Users\your_username\anaconda3\envs

#subsequently to use spyder in the next session, just activate the environment conda activate myenv #in the activated environment, launch spyder spyder

For VS code: Install the following from extension: C# for Visual Studio Code Python for VS code

Also install .NET SDK and add the directories to PATH variables
