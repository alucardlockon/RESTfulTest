var gulp = require('gulp');
var less = require('gulp-less');

gulp.task('html', function(){
    return gulp.src('../html/*.html')
        .pipe(gulp.dest('../../build/html'))
});
/*
gulp.task('css', function(){
    return gulp.src('client/templates/*.less')
        .pipe(less())
        .pipe(minifyCSS())
        .pipe(gulp.dest('build/css'))
});
*/

gulp.task('watch',function(){
    gulp.watch('../html/*.html',['html']);
});

gulp.task('default', [ 'watch']);
