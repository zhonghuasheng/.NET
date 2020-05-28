import echarts from 'echarts';


export default {
    circlepie:function(id,num){
        const myChartDom = document.getElementById(id);
        // 基于准备好的dom，初始化echarts实例
        const myChart = echarts.init(myChartDom);

        var option={
            title:{
                text:"进货进度",
                left:"center",
                top:"52%",
                textStyle:{
                    color:"#fff",
                    fontSize:12,
                    align:"center"
                }
            },
            graphic:{
                type:"text",
                left:"center",
                top:"38%",
                style:{
                    text:num+"%",
                    textAlign:"center",
                    fill:"#fff",
                    fontSize:26,
                }
            },
            series: [
                {
                    hoverAnimation:false,
                    name: '访问来源',
                    type: 'pie',
                    radius: ['55%', '70%'],
                    center: ['50%', '45%'],
                    avoidLabelOverlap: false,
                    startAngle:-132,
                    label: {
                        normal: {
                            show: false,
                            position: 'center'
                        }
                    },
                    data: [
                        {
                            value:num,
                            name: '进货进度',
                            itemStyle: {
                                // color: ['#3e92ff','#4ae2ff'],
                                color:{
                                    type: 'linear',
                                    colorStops: [
                                        {offset: 0, color: '#3e92ff' // 0% 处的颜色
                                        },
                                        {
                                            offset: 1, color: '#4ae2ff' // 100% 处的颜色
                                        }],
                                    globalCoord: true // 缺省为 false
                                }
                            }
                        },
                        {
                            value:100-num,
                            name: '剩余进度',
                            itemStyle: {
                                color: '#213962'
                            }
                        },
                        {
                            value: 30,
                            name: '透明',
                            itemStyle: {
                                color: 'transparent'
                            }
                        },
                    ]
                }
            ]
        }

        myChart.setOption(option);

    },
    detailpie:function(id,arr){
        const myChartDom = document.getElementById(id);
        // 基于准备好的dom，初始化echarts实例
        const myChart = echarts.init(myChartDom);

        var option = {
            color: ['#f25f42','#009eff', '#09c5db', '#46c75e', '#fecb4a'],
            title:{
                text:"支出费用情况",
                left:"5%",
                top:"5%",
                textStyle:{
                    color:"#fff",
                    fontSize:22,
                }
            },
            tooltip : {
                trigger: 'item',
                formatter: "{b} <br/> {c}万元 ({d}%)"
            },
            legend: {
                orient: 'horizontal',
                bottom:8,
                color:'#fff',
                itemGap:25,
                itemWidth:14,
                textStyle:{
                    color:"#fff"
                },
                data: ['直接访问','邮件营销','联盟广告','视频广告','搜索引擎']
            },
            series : [
                {
                    label: {
                        textStyle:{
                            color:"#fff"
                        },
                        formatter:'{b}\n{c}万元',
                        lineHeight:18,
                        align:'center'
                    },
                    name: '访问来源',
                    type: 'pie',
                    radius: ['32%', '50%'],
                    center: ['50%', '53%'],
                    data:arr,
                    itemStyle: {
                        emphasis: {
                            shadowBlur: 10,
                            shadowOffsetX: 0,
                            shadowColor: 'rgba(0, 0, 0, 0.5)'
                        }
                    }
                }
            ]
        };


        myChart.setOption(option);

    },
    simplepie:function(id,name,num){
        const myChartDom = document.getElementById(id);
        // 基于准备好的dom，初始化echarts实例
        const myChart = echarts.init(myChartDom);

        var option={
            title:{
                text:name,
                left:"center",
                top:"50%",
                textStyle:{
                    color:"#fff",
                    fontSize:12,
                    align:"center"
                }
            },
            graphic:{
                type:"text",
                left:"center",
                top:"32%",
                style:{
                    text:num+"%",
                    textAlign:"center",
                    fill:"#fff",
                    fontSize:22,
                }
            },
            series: [
                {
                    hoverAnimation:false,
                    name: '访问来源',
                    type: 'pie',
                    radius: ['75%', '100%'],
                    center: ['50%', '50%'],
                    avoidLabelOverlap: false,
                    startAngle:-90,
                    label: {
                        normal: {
                            show: false,
                            position: 'center'
                        }
                    },
                    data: [
                        {
                            value:num,
                            name: '进货进度',
                            itemStyle: {
                                color:{
                                    type: 'linear',
                                    colorStops: [
                                        {offset: 0.01, color: '#3e92ff' // 0% 处的颜色
                                        },
                                        {
                                            offset: 1, color: '#4ae2ff' // 100% 处的颜色
                                        }],
                                    // globalCoord: true // 缺省为 false
                                }
                            }
                        },
                        {
                            value:100-num,
                            name: '剩余进度',
                            itemStyle: {
                                color: '#213962'
                            }
                        },
                    ]
                }
            ]
        }

        myChart.setOption(option);

    },

}