<template>
    <div class="mymaps">
        <div class="top">
            <p>湖南明源云作战地图</p>
        </div>
        <div class="mid">
            <div class="center">
                <div class="cen-top">
                    <div class="bar">
                        <div class="block">
                            <div class="p" id="p1"></div>
                            <div class="mes">
                                <div class="mes-block">
                                    <p class="t">利润目标</p>
                                    <p class="money"><span style="color:#63B3FF;">1500.00</span>万元</p>
                                </div>
                                <div class="mes-block">
                                    <p class="t">累计目标</p>
                                    <p class="money"><span style="color:#FFD056;">1000.00</span>万元</p>
                                </div>
                            </div>
                        </div>
                        <div class="block">
                            <div class="p" id="p2"></div>
                            <div class="mes">
                                <div class="mes-block">
                                    <p class="t">利润目标</p>
                                    <p class="money"><span style="color:#63B3FF;">1500.00</span>万元</p>
                                </div>
                                <div class="mes-block">
                                    <p class="t">累计目标</p>
                                    <p class="money"><span style="color:#FFD056;">1000.00</span>万元</p>
                                </div>
                            </div>
                        </div>
                        <div class="block">
                            <div class="p" id="p3"></div>
                            <div class="mes">
                                <div class="mes-block">
                                    <p class="t">利润目标</p>
                                    <p class="money"><span style="color:#63B3FF;">1500.00</span>万元</p>
                                </div>
                                <div class="mes-block">
                                    <p class="t">累计目标</p>
                                    <p class="money"><span style="color:#FFD056;">1000.00</span>万元</p>
                                </div>
                            </div>
                        </div>
                        <div class="block">
                            <div class="p" id="p4"></div>
                            <div class="mes">
                                <div class="mes-block">
                                    <p class="t">利润目标</p>
                                    <p class="money"><span style="color:#63B3FF;">1500.00</span>万元</p>
                                </div>
                                <div class="mes-block">
                                    <p class="t">累计目标</p>
                                    <p class="money"><span style="color:#FFD056;">1000.00</span>万元</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="cen-bot">
                    <div class="left">
                        <div class="b">
                            <div class="b1"></div>
                            <div class="b2"></div>
                            <div class="b3"></div>
                            <div class="b4"></div>
                            <div class="b5"></div>
                            <div class="b6"></div>
                            <div class="l1"></div>
                            <div class="l2"></div>
                            <div class="l3"></div>
                            <div class="l4"></div>
                        </div>
                        <div class="tit">
                            <p class="t">销售收入</p>
                            <el-select v-model="value" placeholder="长沙公司">
                                <el-option
                                        v-for="item in options"
                                        :key="item.value"
                                        :label="item.label"
                                        :value="item.value">
                                </el-option>
                            </el-select>
                        </div>
                        <div class="unit-top">
                            <el-checkbox class="check" v-model="checkall" @change="handleCheckAllChange">全部</el-checkbox>
                            <p class="num">1214.68万元</p>
                        </div>
                        <div class="list-wrap">
                            <div class="unit" v-for="(mes,index) in datalist">
                                <el-checkbox class="check" v-model="checkall">
                                    <img class="num" v-if="index==0" src="../assets/mymaps/01.png" alt="">
                                    <img class="num" v-else-if="index==1" src="../assets/mymaps/02.png" alt="">
                                    <img class="num" v-else-if="index==2" src="../assets/mymaps/03.png" alt="">
                                    <span v-else>{{index+1}}</span>
                                    
                                </el-checkbox>
                                <div class="mes-wrap">
                                    <p class="name">ERP产品</p>
                                    <p class="num">1024万元</p>
                                    <el-progress :percentage="50" class="progress"></el-progress>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="main">

                    </div>
                </div>

            </div>
            <div class="right">
                <div class="sele-wrap">
                    <el-select v-model="value" placeholder="长沙公司">
                        <el-option
                                v-for="item in options"
                                :key="item.value"
                                :label="item.label"
                                :value="item.value">
                        </el-option>
                    </el-select>
                    <el-select v-model="value2" placeholder="2019年">
                        <el-option
                                v-for="item in options"
                                :key="item.value"
                                :label="item.label"
                                :value="item.value">
                        </el-option>
                    </el-select>
                    <el-select v-model="value3" placeholder="1月">
                        <el-option
                                v-for="item in options"
                                :key="item.value"
                                :label="item.label"
                                :value="item.value">
                        </el-option>
                    </el-select>
                </div>
                <div class="right1">
                    <div class="b">
                        <div class="b1"></div>
                        <div class="b2"></div>
                        <div class="b3"></div>
                        <div class="b4"></div>
                        <div class="b5"></div>
                        <div class="b6"></div>
                        <div class="l1"></div>
                        <div class="l2"></div>
                        <div class="l3"></div>
                        <div class="l4"></div>
                    </div>
                    <p class="t">累计进货完成目标</p>
                    <div class="r1" id="r1"></div>
                    <p class="target">进货目标：1200万</p>
                    <div class="num">累计进货：800万</div>
                </div>
                <div class="right2">
                    <div class="b">
                        <div class="b1"></div>
                        <div class="b2"></div>
                        <div class="b3"></div>
                        <div class="b4"></div>
                        <div class="b5"></div>
                        <div class="b6"></div>
                        <div class="l1"></div>
                        <div class="l2"></div>
                        <div class="l3"></div>
                        <div class="l4"></div>
                    </div>
                    <p class="num">总额 <span style="font-size: 20px">2488</span> 万元</p>
                    <div class="r2" id="r2"></div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

    // 基于准备好的dom，初始化echarts实例
    import echart from "../echart/echart"

    export default {
        name: "mymaps",
        props: {},
        data() {
            return {
                options:[],
                value:"长沙公司",
                value2:"2019年",
                value3:"1月",
                datalist:[{check:false,},{check:false},{check:false},{check:false}],
                checkall:false,
            }
        },
        methods: {
            handleCheckAllChange(){

            }
        },
        mounted() {
            echart.circlepie("r1",50);
            var arr=[
                {value:456, name:'直接访问'},
                {value:735, name:'邮件营销'},
                {value:623, name:'联盟广告'},
                {value:1024, name:'视频广告'},
                {value:256, name:'搜索引擎'}
            ];
            echart.detailpie("r2",arr);
            echart.simplepie("p1","利润进度",60);
            echart.simplepie("p2","销售进度",80);
            echart.simplepie("p3","回款进度",40);
            echart.simplepie("p4","成本进度",50);
            // axios.get("http://10.5.11.35:2001/pub/Mysoft.LYHT.Contract.Interfaces.IContractPublicService/GetOperationalMapList", {
            //     params: {
            //         Buname: "长沙公司",
            //         x_Year:"2019",
            //         x_Month:"1"
            //     }
            // })
            //     .then(res => {
            //         console.log(res)
            //     }).catch(error => {
            //     console.log(error);
            //     this.$message.error(error);
            // });


            axios({
                method: "GET",
                url: `http://10.5.11.35:2001/pub/Mysoft.LYHT.Contract.Interfaces.IContractPublicService/GetOperationalMapList`,
                params: {
                    Buname: "长沙公司",
                    x_Year:"2019",
                    x_Month:"1"
                },
                headers: {
                    'Content-Type': 'application/json',
                    'AppID':"huiqianxitong",
                    'AppKey':"5a5e9bfe1123b1bc"
                }
            }).then(res => {
                console.log(res);
            });
        }
    }
</script>

<style lang="scss">
    html,body{
        width: 100%;
        height: 100%;
        min-height:974px;
        min-width: 1424px;
        position: relative;
    }
    .mymaps {
        position: relative;
        width: 100%;
        height: 100%;
        background-image: url(../assets/mymaps/bj.png);
        -webkit-background-size: 100% 100%;
        background-size: 100% 100%;
        .top {
            width: 100%;
            height: 80px;
            background-image: url(../assets/mymaps/tit.png);
            -webkit-background-size: 100% 100%;
            background-size: 100% 100%;
            p{
                color: white;
                font-size: 25px;
                line-height: 60px;
            }
        }
        .mid {
            width: 100%;
            height: calc(100% - 110px);
            position: relative;
            display: flex;
            margin-top: 10px;
            .center {
                width:calc(100% - 380px);
                height: 100%;
                position: relative;
                .cen-top{
                    width: 100%;
                    height: 125px;
                    position: relative;
                    margin-bottom: 20px;
                    margin-left: 20px;
                    .bar{
                        width: 100%;
                        height: 125px;
                        position: relative;
                        display: flex;
                        justify-content: space-around;
                        .block{
                            width: 230px;
                            height: 135px;
                            position: relative;
                            margin-right: 20px;
                            .p{
                                position: relative;
                                width: 125px;
                                height: 125px;
                            }
                            .mes{
                                position: absolute;
                                right: 0;
                                top: 0;
                                color: white;
                                .mes-block{
                                    position: relative;
                                    margin-top: 15px;
                                    font-size: 14px;
                                    p{
                                        width: 95px;
                                        text-align: left;
                                    }
                                }
                            }
                        }
                    }
                }
                .cen-bot{
                    width: 100%;
                    height: calc(100% - 135px);
                    position: relative;
                    .left {
                        width: 365px;
                        height: calc(100% - 27px);
                        position: relative;
                        margin-left: 20px;
                        padding-top: 20px;
                        box-sizing: border-box;
                        .tit{
                            position: relative;
                            .t{
                                font-size: 24px;
                                color: #FFFFFF;
                                text-align: left;
                                text-indent: 18px;
                            }
                            .el-select{
                                width: 150px;
                                position:absolute;
                                right: 20px;
                                top: 0;
                            }
                        }
                        .unit-top{
                            width: 90%;
                            position: relative;
                            left: 5%;
                            display: flex;
                            flex-wrap: wrap;
                            justify-content: space-between;
                            margin-top: 20px;
                            color: white;
                            .check{
                                color: white;
                            }
                            .num{
                                width: 50%;
                                text-align: right;
                                position: relative;
                                display: inline-block;
                            }
                        }
                        .list-wrap{
                            width: 90%;
                            height: calc(100% - 100px);
                            position: relative;
                            color: white;
                            left: 5%;
                            .unit{
                                width: 100%;
                                height: 45px;
                                position: relative;
                                display: flex;
                                margin-top: 15px;
                                .check{
                                    position: relative;
                                    top: 12px;
                                    color: white;
                                    width: 60px;
                                    text-align: left;
                                    margin-right: 15px;
                                    .num{
                                        position: relative;
                                        display: inline-block;
                                        margin-top: -15px;
                                        top: 8px;
                                        width: 25px;
                                        height: 25px;
                                    }
                                }
                                .mes-wrap{
                                    display: inline-block;
                                    width: calc(100% - 35px);
                                    position: relative;
                                    p{
                                        display: inline-block;
                                    }
                                    .name{
                                        position: absolute;
                                        left: 0;
                                        top: 0;
                                    }
                                    .num{
                                        position: absolute;
                                        right: 0;
                                        top: 0;
                                    }
                                    .progress{
                                        width: 106%;
                                        position: relative;
                                        left: -3%;
                                        top: 25px;
                                    }
                                    .el-progress__text{
                                        color: white;
                                    }
                                }

                            }
                        }
                    }
                    .main{
                        width: calc(100% - 365px);

                    }
                }

            }
            .right {
                height: calc(100% - 30px);
                width: 350px;
                .sele-wrap{
                    width: 100%;
                    position: relative;
                    display: flex;
                    flex-wrap: wrap;
                    justify-content: space-between;
                    margin-bottom: 20px;
                    .el-select{
                        width: 100px;
                    }
                }
                .right1{
                    width:350px;
                    height:42%;
                    position: relative;
                    padding-top: 20px;
                    box-sizing: border-box;
                    .t{
                        font-size: 24px;
                        color: #FFFFFF;
                        letter-spacing: 0;
                        text-align: left;
                        position: absolute;
                        left: 7%;
                        top: 10%;
                    }
                    .r1{
                        width: 240px;
                        height: 240px;
                        position: absolute;
                        left: 50%;
                        top: 20%;
                        margin-left: -120px;
                    }
                    .target{
                        font-size: 16px;
                        color: #FFFFFF;
                        letter-spacing: 0;
                        text-align: center;
                        position: absolute;
                        bottom: 18%;
                        width: 100%;
                    }
                    .num{
                        font-size: 16px;
                        color: #FFFFFF;
                        letter-spacing: 0;
                        text-align: center;
                        position: absolute;
                        bottom: 10%;
                        width: 100%;
                        .block{
                            width: 14px;
                            height: 14px;
                            background-color: #4adcff;
                            display: inline-block;
                            margin-right:10px;
                            border-radius: 2px;
                            position: relative;
                            top:2px;
                        }
                    }
                }
                .right2{
                    width:350px;
                    height: 50%;
                    position: relative;
                    margin-top: 5%;
                    .num{
                        font-size: 14px;
                        color: #FFFFFF;
                        text-align: left;
                        line-height: 22px;
                        position: absolute;
                        left: 7%;
                        top: 15%;
                    }
                    .r2{
                        width: 350px;
                        height:100%;
                        position: absolute;
                        top: 0%;
                    }
                }
            }
        }
    }
    .el-select{
        input{
            font-size: 12px;
            background-color: #172d5b;
            border-color: #047aff;
            height: 34px;
            line-height: 34px;
            color: white;
        }
        .el-select__caret{
            line-height: 34px;
        }

    }

    .b1{
        width: 20px;
        height: 4px;
        position: absolute;
        left: 0;
        top: 0;
        background-color: #48a8ff;
    }
    .b2{
        width: 20px;
        height: 4px;
        position: absolute;
        right: 0;
        top: 0;
        background-color: #48a8ff;
    }
    .b3{
        width: 20px;
        height: 4px;
        position: absolute;
        left: 0;
        bottom: 0;
        background-color: #48a8ff;
    }
    .b4{
        width: 4px;
        height: 20px;
        position: absolute;
        left: 0;
        bottom: 0;
        background-color: #48a8ff;
    }
    .b5{
        width: 20px;
        height: 4px;
        position: absolute;
        right: 0;
        bottom: 0;
        background-color: #48a8ff;
    }
    .b6{
        width: 4px;
        height: 20px;
        position: absolute;
        right: 0;
        bottom: 0;
        background-color: #48a8ff;
    }
    .l1{
        height: 1px;
        width: 100%;
        position: absolute;
        left: 0;
        top: 0;
        background-color: #2f5298;
        box-shadow:0px 0px 30px white;
    }
    .l2{
        height: 1px;
        width: 100%;
        position: absolute;
        left: 0;
        bottom: 0;
        background-color: #2f5298;
        box-shadow:0px 0px 30px white;
    }
    .l3{
        height:100%;
        width: 1px;
        position: absolute;
        left: 0;
        top: 0;
        background-color: #2f5298;
        box-shadow:0px 0px 30px white;
    }
    .l4{
        height:100%;
        width: 1px;
        position: absolute;
        right: 0;
        top: 0;
        background-color: #2f5298;
        box-shadow:0px 0px 30px white;
    }
</style>