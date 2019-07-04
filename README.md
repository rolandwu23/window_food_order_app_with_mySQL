# window_food_order_app_with_mySQL
Window App with C#  and MySQLfor food ordering

Overview

Using Anaconda consists of the following:

Install miniconda on your computer, by selecting the latest Python version for your operating system. If you already have conda or miniconda installed, you should be able to skip this step and move on to step 2.
Create and activate * a new conda environment.
* Each time you wish to work on any exercises, activate your conda environment!

1. Installation

Download the latest version of miniconda that matches your system.

Linux	Mac	Windows
64-bit	64-bit (bash installer)	64-bit (bash installer)	64-bit (exe installer)
32-bit	32-bit (bash installer)		32-bit (exe installer)
Install miniconda on your machine. Detailed instructions:

Linux: http://conda.pydata.org/docs/install/quick.html#linux-miniconda-install
Mac: http://conda.pydata.org/docs/install/quick.html#os-x-miniconda-install
Windows: http://conda.pydata.org/docs/install/quick.html#windows-miniconda-install
2. Create and Activate the Environment

For Windows users, these following commands need to be executed from the Anaconda prompt as opposed to a Windows terminal window. For Mac, a normal terminal window will work.

Git and version control

These instructions also assume you have git installed for working with Github from a terminal window, but if you do not, you can download that first with the command:

conda install git
If you'd like to learn more about version control and using git from the command line, take a look at our free course: Version Control with Git.

Now, we're ready to create our local environment!

Clone the repository, and navigate to the downloaded folder. This may take a minute or two to clone due to the included image data.
git clone https://github.com/udacity/deep-learning-v2-pytorch.git
cd deep-learning-v2-pytorch
Create (and activate) a new environment, named deep-learning with Python 3.6. If prompted to proceed with the install (Proceed [y]/n) type y.

Linux or Mac:
conda create -n deep-learning python=3.6
source activate deep-learning
Windows:
conda create --name deep-learning python=3.6
activate deep-learning
At this point your command line should look something like: (deep-learning) <User>:deep-learning-v2-pytorch <user>$. The (deep-learning) indicates that your environment has been activated, and you can proceed with further package installations.

Install PyTorch and torchvision; this should install the latest version of PyTorch.

Linux or Mac:
conda install pytorch torchvision -c pytorch 
Windows:
conda install pytorch -c pytorch
pip install torchvision
Install a few required pip packages, which are specified in the requirements text file (including OpenCV).

pip install -r requirements.txt
That's it!
Now most of the deep-learning libraries are available to you. Very occasionally, you will see a repository with an addition requirements file, which exists should you want to use TensorFlow and Keras, for example. In this case, you're encouraged to install another library to your existing environment, or create a new environment for a specific project.

Now, assuming your deep-learning environment is still activated, you can navigate to the main repo and start looking at the notebooks:

cd
cd deep-learning-v2-pytorch
jupyter notebook
To exit the environment when you have completed your work session, simply close the terminal window.
