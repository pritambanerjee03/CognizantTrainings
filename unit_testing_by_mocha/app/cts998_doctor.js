exports.getBP = function(systolic,diastolic){
    if(typeof systolic == 'number' && typeof diastolic == 'number')
    {
        if((systolic > 90 && systolic<120) && (diastolic >60 && diastolic <80)){
            return 'normal'
        }else{
            return 'abnormal'
        }
    }
}