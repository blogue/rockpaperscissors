//get input from arrow keys
  window.addEventListener("keydown", moveSomething, false);
  function moveSomething(e) {
    switch(e.keyCode) {
      case 37://left
        $('#player2choice').val('rock');
        break;
      case 65://a
        $('#player1choice').val('rock');
        break;
      case 39://right
        $('#player2choice').val('scissors');
        break;
      case 68://d
        $('#player1choice').val('scissors');
        break;
      case 40://down
        $('#player2choice').val('paper');
        break;
      case 83://s
        $('#player1choice').val('paper');
        break;
    }
  }

$('#countdown').text('5');
var timer = setInterval(function() {
  $("#countdown").text(function(i,html) {
    if(parseInt(html)>0)
    {
      return parseInt(html)-1;
    } else {
      clearTimeout(timer);
      return "Shoot!";
    }
  });
}, 1000);
