var videoPlayer = document.getElementsByTagName('video')[0];

videoPlayer.onended = function() {
  console.log('video end');
};

videoPlayer.play();
