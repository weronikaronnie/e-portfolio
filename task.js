function addTask() {
    let taskInput = document.getElementById('taskInput').value;
    if (taskInput.trim() !== '') {
      let task = { taskName: taskInput };
      let tasks = localStorage.getItem('tasks') ? JSON.parse(localStorage.getItem('tasks')) : [];
      tasks.push(task);
      localStorage.setItem('tasks', JSON.stringify(tasks));
      displayTasks();
    }
  }
  
  function displayTasks() {
    let tasks = localStorage.getItem('tasks') ? JSON.parse(localStorage.getItem('tasks')) : [];
    let taskList = document.getElementById('taskList');
    taskList.innerHTML = '';
    tasks.forEach(function (task) {
      let li = document.createElement('li');
      li.textContent = task.taskName;
      taskList.appendChild(li);
    });
  }
  
  displayTasks();
  