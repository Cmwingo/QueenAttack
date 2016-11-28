$(Document).ready(function() {
  $("form").submit(function(event){
  event.preventDefault();
  $("#result").show();
  });
});
