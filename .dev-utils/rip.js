var fs = require('fs');
var youtubedl = require('youtube-dl');
var argv = require('minimist')(process.argv.slice(2));


if(argv.url){
  //dlVideo(argv.url, argv.output, argv.start, argv.end);
  dlAudio(argv.url, argv.output, argv.start, argv.end);
} else{
  console.log("You must provide a video URL and a destination filename");
}

function dlAudio(url, start, end){
  youtubedl.exec(url, [
    '-x', '--audio-format', 'mp3'
    ], {}, function(err, output){
       if (err) throw err;
       console.log(output.join('\n'));
    });
}
