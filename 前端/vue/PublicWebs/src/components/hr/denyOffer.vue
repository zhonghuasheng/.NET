<template>
    <div class="deny-offer">
        <div class="wrap">
            <h3>您确定拒绝offer吗</h3>
            <el-button class="bt" type="primary" @click="refuseOffer">拒绝offer</el-button>
            <el-button class="bt" type="primary" @click="acceptOffer">不，我接受offer</el-button>
        </div>
    </div>
</template>

<script>
    export default {
        name: "deny-offer",
        props: {},
        data() {
            return {}
        },
        methods: {
            acceptOffer(){
                var oid = this.$route.query.oid;
                this.$router.push({path:"/hr/mescollect?oid="+oid})
            },
            refuseOffer(){
                var oid = this.$route.query.oid;
                axios.get("API/Common/RefuseOffer", {
                    params: {
                        oid: oid
                    }
                })
                    .then(res => {
                        console.log(res)
                        this.$router.push({path:"/hr/success"})
                    }).catch(error => {
                    console.log(error);
                    this.$message.error(error);
                });
            }
        },
        mounted() {

        }
    }
</script>

<style lang="scss">
    .deny-offer{
        width: 100%;
        height: 100%;
        position: relative;
        display: flex;
        justify-content: center;
        align-items: center;
        background-color: #ccc;
        .wrap{
            width: 600px;
            height: 150px;
            position: relative;
            background-color: #fff;
            top: -100px;
            border-radius: 5px;
            h3{
                font-size: 30px;
                margin-top: 15px;
            }
            .bt{
                margin-top: 20px;
                margin-right: 25px;
                margin-left: 25px;
            }
        }
    }

</style>