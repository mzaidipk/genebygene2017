var exec = require('child_process').exec;
var fs = require('fs');
process.argv.slice(2).forEach(function (arg) {
    var cmd = 'ng g module modules/' + arg + ' --routing';
    console.log(cmd);
    exec(cmd, function (error, stdout, stderr) {
        var cmd = 'ng g service modules/' + arg + '/' + arg;
        console.log(cmd);
        exec(cmd, function (error, stdout, stderr) {
            fs.mkdir('src/app/modules/' + arg + '/models');
            var cmd = 'ng g class modules/' + arg + '/models/' + arg;
            console.log(cmd);
            exec(cmd, function (error, stdout, stderr) {
                fs.mkdir('src/app/modules/' + arg + '/components');
                fs.rename('src/app/modules/'+arg+'/'+arg+'.component.scss', 'src/app/modules/'+arg+'/components/'+arg+'.component.scss', function (err) {});
                fs.rename('src/app/modules/'+arg+'/'+arg+'.component.spec.ts', 'src/app/modules/'+arg+'/components/'+arg+'.component.spec.ts', function (err) {});
                fs.rename('src/app/modules/'+arg+'/'+arg+'.component.ts', 'src/app/modules/'+arg+'/components/'+arg+'.component.ts', function (err) {});
                fs.rename('src/app/modules/'+arg+'/'+arg+'.component.html', 'src/app/modules/'+arg+'/components/'+arg+'.component.html', function (err) {});
            });
        });
    });
});