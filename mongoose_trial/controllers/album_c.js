var models_album = require('../models/album_m');

module.exports = {
    find_all : async(req,res) => {
        try{
            var albums = await models_album.find().exec();
            res.send(albums);
        }catch(err){
            res.status(500).send(err);
        }
    },
    find_one : async(req,res) => {
        try{
            var album = await models_album.findById(req.params.id).exec();
            res.send(album);
        }catch(err){
            res.status(500).send(err);
        }
    },
    add: async (req, res) => {
        try {
            console.log(req.body)
            var album = new models_album(req.body);
            var result = await album.save();
            res.send(result)
        } catch (err) {
            res.status(500).send(err);
        }
    },
    delete : async(req,res) => {
        try{
            var result = await models_album.deleteOne({ _id : req.params.id}).exec();
            res.send(result);
        }catch(err){
            res.status(500).send(err);
        }
    },
    update : async(req,res) => {
        try{
            var album = await models_album.findById({ _id : req.params.id}).exec();
            album.set(req.body)
            var result = await album.save()
            res.send('output : '+result);


        }catch(err){
            res.status(500).send(err);
        }
    }
}