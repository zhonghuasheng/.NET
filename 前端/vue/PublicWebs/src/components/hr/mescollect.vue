<template>
    <div class="mescollect" v-loading="loading">
        <div style="margin-top: 20px" class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>基本信息</p>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap" v-if="BaseInfo">
                <div class="count-in">
                    <el-form :model="BaseInfo" :rules="rules" ref="Baseinfo" class="form-inline">
                        <el-row :gutter="40">
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>姓名:</label>
                                        <el-form-item prop="CandidateName">
                                            <el-input v-model="BaseInfo.CandidateName" placeholder="请输入"
                                                      required></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>证件姓名:</label>
                                        <el-form-item prop="CertificateName">
                                            <el-input v-model="BaseInfo.CertificateName" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>证件类型:</label>
                                        <el-form-item prop="CertificateType">
                                            <el-select v-model="BaseInfo.CertificateType" placeholder="请选择">
                                                <el-option
                                                        v-for="item in CertificateTypeLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>证件号码:</label>
                                        <el-form-item prop="CertificateCode">
                                            <el-input v-model="BaseInfo.CertificateCode" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>民族:</label>
                                        <el-form-item prop="Nation">
                                            <el-select v-model="BaseInfo.Nation" placeholder="请选择">
                                                <el-option
                                                        v-for="item in NationLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>出生日期:</label>
                                        <el-form-item prop="Birthday">
                                            <el-date-picker
                                                    value-format="yyyy-MM-dd"
                                                    v-model="BaseInfo.Birthday"
                                                    align="right"
                                                    type="date"
                                                    placeholder="选择日期"
                                                    :picker-options="pickerOptions">
                                            </el-date-picker>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>性别:</label>
                                        <el-form-item prop="Gender">
                                            <el-select v-model="BaseInfo.Gender" placeholder="请选择">
                                                <el-option
                                                        v-for="item in GenderLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>私人邮箱:</label>
                                        <el-form-item prop="Email">
                                            <el-input v-model="BaseInfo.Email" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>手机号码:</label>
                                        <el-form-item prop="MobilePhone">
                                            <el-input v-model="BaseInfo.MobilePhone" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab2">微信: </label>
                                        <el-input v-model="BaseInfo.WeChart" placeholder="请输入"></el-input>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab2">QQ: </label>
                                        <el-input v-model="BaseInfo.QQ" placeholder="请输入"></el-input>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab2">工资卡号:</label>
                                        <el-input v-model="BaseInfo.WageNumbers" :placeholder="BaseInfo.IsDirect=='1'?'填写招商银行卡卡号':''"></el-input>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>政治面貌:</label>
                                        <el-form-item prop="PoliticalStations">
                                            <el-select v-model="BaseInfo.PoliticalStations" placeholder="请选择">
                                                <el-option
                                                        v-for="item in PoliticalStationLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>户口性质:</label>
                                        <el-form-item prop="NatureAccount">
                                            <el-select v-model="BaseInfo.NatureAccount" placeholder="请选择">
                                                <el-option
                                                        v-for="item in NatureAccountLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>籍贯:</label>
                                        <el-form-item prop="NativePlaceName">
                                            <el-input v-model="BaseInfo.NativePlaceName" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>婚姻状况:</label>
                                        <el-form-item prop="MaritalStatus">
                                            <el-select v-model="BaseInfo.MaritalStatus" placeholder="请选择">
                                                <el-option
                                                        v-for="item in MaritalStatusLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>生育状况:</label>
                                        <el-form-item prop="FertilityStatus">
                                            <el-select v-model="BaseInfo.FertilityStatus" placeholder="请选择">
                                                <el-option
                                                        key="1"
                                                        label="是"
                                                        value="1">
                                                </el-option>
                                                <el-option
                                                        key="0"
                                                        label="否"
                                                        value="0">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>健康状况:</label>
                                        <el-form-item prop="Health">
                                            <el-select v-model="BaseInfo.Health" placeholder="请选择">
                                                <el-option
                                                        v-for="item in HealthLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1"><span class="red">*</span>最高学历:</label>
                                        <el-form-item prop="HighestQualification">
                                            <el-select v-model="BaseInfo.HighestQualification" placeholder="请选择">
                                                <el-option
                                                        v-for="item in QualificationLst"
                                                        :key="item"
                                                        :label="item"
                                                        :value="item">
                                                </el-option>
                                            </el-select>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label><span class="red">*</span>参加工作时间:</label>
                                        <el-form-item prop="WorkTime">
                                            <el-date-picker
                                                    value-format="yyyy-MM-dd"
                                                    v-model="BaseInfo.WorkTime"
                                                    align="right"
                                                    type="date"
                                                    placeholder="选择日期"
                                                    :picker-options="pickerOptions">
                                            </el-date-picker>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab1">招聘渠道:</label>
                                        <el-select v-model="BaseInfo.RecruitmentChannels" placeholder="请选择">
                                            <el-option
                                                    v-for="item in RecruitmentChannelsLst"
                                                    :key="item"
                                                    :label="item"
                                                    :value="item">
                                            </el-option>
                                        </el-select>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label>社会累计工龄大于10年:</label>
                                        <el-select v-model="BaseInfo.ISMoreThenTenYears" placeholder="请选择">
                                            <el-option
                                                    v-for="item in options"
                                                    :key="item.value"
                                                     :label="item.label"
                                                    :value="item.value">
                                            </el-option>
                                        </el-select>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6" v-if="BaseInfo.IsWuhan=='1'">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label>武汉有社保公积金:</label>
                                        <el-select v-model="BaseInfo.ISPaySocialSecurityInWH" placeholder="请选择">
                                            <el-option
                                                    v-for="item in options"
                                                    :key="item.value"
                                                    :label="item.label"
                                                    :value="item.value">
                                            </el-option>
                                        </el-select>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label>在明源是否有亲属:</label>
                                        <el-select v-model="BaseInfo.IsHaveKinsfolk" placeholder="请选择">
                                            <el-option
                                                    v-for="item in options"
                                                    :key="item.value"
                                                    :label="item.label"
                                                    :value="item.value">
                                            </el-option>
                                        </el-select>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="6">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label>是否有入职推荐人:</label>
                                        <el-select v-model="BaseInfo.IsHaveReferrer" placeholder="请选择">
                                            <el-option
                                                    v-for="item in options"
                                                    :key="item.value"
                                                    :label="item.label"
                                                    :value="item.value">
                                            </el-option>
                                        </el-select>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="12">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab3"><span class="red">*</span>户籍地址(精确到门牌号):</label>
                                        <el-form-item prop="HouseholdAddress">
                                            <el-input class="adress" v-model="BaseInfo.HouseholdAddress" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                            <el-col :span="12">
                                <div class="grid-content">
                                    <div class="inp-wrap">
                                        <label class="lab3"><span class="red">*</span>现住址(精确到门牌号):</label>
                                        <el-form-item prop="Address">
                                            <el-input class="adress" v-model="BaseInfo.Address" placeholder="请输入"></el-input>
                                        </el-form-item>
                                    </div>
                                </div>
                            </el-col>
                        </el-row>
                    </el-form>
                </div>
            </div>
        </div>
        <div class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>教育经历</p>
                <div class="add" @click="add('EducationLst')"><i class="iconfont icon-xinzeng1"></i>添加</div>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap">
                <div class="count-in">
                    <el-table
                            class="tables"
                            border
                            :data="EducationLst"
                            align="center"
                            style="width: 100%">
                        <el-table-column
                                label="序号"
                                type="index"
                                align="center"
                                width="50">
                        </el-table-column>
                        <el-table-column
                                prop="GraduateSchool"
                                align="center"
                                label="毕业院校">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.GraduateSchool==''}"
                                          v-model="scope.row.GraduateSchool" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Professional"
                                label="专业">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.Professional==''}"
                                          v-model="scope.row.Professional" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Education"
                                label="学历">
                            <template scope="scope">
                                <el-select class="quire" :class="{'red':scope.row.Education==''}"
                                           v-model="scope.row.Education" placeholder="请选择">
                                    <el-option
                                            v-for="item in QualificationLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Degree"
                                label="学位">
                            <template scope="scope">
                                <el-select class="quire" :class="{'red':scope.row.Degree==''}"
                                           v-model="scope.row.Degree" placeholder="请选择">
                                    <el-option
                                            v-for="item in DegreeLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="160"
                                align="center"
                                prop="EntranceTime"
                                label="入学日期">
                            <template scope="scope">
                                <el-date-picker
                                        :class="{'red':scope.row.EntranceTime==''}"
                                        class="quire"
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.EntranceTime"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="160"
                                align="center"
                                prop="GraduationTime"
                                label="毕业日期">
                            <template scope="scope">
                                <el-date-picker
                                        :class="{'red':scope.row.GraduationTime==''}"
                                        class="quire"
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.GraduationTime"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="EducationNature"
                                label="学历性质">
                            <template scope="scope">
                                <el-select class="quire" :class="{'red':scope.row.EducationNature==''}"
                                           v-model="scope.row.EducationNature" placeholder="请选择">
                                    <el-option
                                            v-for="item in EducationNatureLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Remark"
                                label="备注">
                            <template scope="scope">
                                <el-input v-model="scope.row.Remark" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="100"
                                align="center"
                                prop="address"
                                label="操作">
                            <template scope="scope">
                                <el-button type="text" @click="del('EducationLst',scope.$index)">删除</el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </div>
            </div>
        </div>
        <div class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>工作经历</p>
                <div class="add" @click="add('WorkExperienceLst')"><i class="iconfont icon-xinzeng1"></i>添加
                </div>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap">
                <div class="count-in">
                    <el-table
                            class="tables"
                            border
                            :data="WorkExperienceLst"
                            align="center"
                            style="width: 100%">
                        <el-table-column
                                label="序号"
                                type="index"
                                align="center"
                                width="50">
                        </el-table-column>
                        <el-table-column
                                prop="CompanyName"
                                align="center"
                                label="公司名称">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.CompanyName==''}"
                                          v-model="scope.row.CompanyName" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="PositionName"
                                label="职位名称">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.PositionName==''}"
                                          v-model="scope.row.PositionName" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="160"
                                align="center"
                                prop="BeginDate"
                                label="开始日期">
                            <template scope="scope">
                                <el-date-picker
                                        :class="{'red':scope.row.BeginDate==''}"
                                        class="quire"
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.BeginDate"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="160"
                                align="center"
                                prop="EndDate"
                                label="结束日期">
                            <template scope="scope">
                                <el-date-picker
                                        :class="{'red':scope.row.EndDate==''}"
                                        class="quire"
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.EndDate"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Remark"
                                label="备注">
                            <template scope="scope">
                                <el-input v-model="scope.row.Remark" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="100"
                                align="center"
                                prop="address"
                                label="操作">
                            <template scope="scope">
                                <el-button type="text" @click="del('WorkExperienceLst',scope.$index)">删除</el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </div>
            </div>
        </div>
        <div class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>家庭状况</p>
                <div class="add" @click="add('FamilyMemberLst')"><i class="iconfont icon-xinzeng1"></i>添加</div>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap">
                <div class="count-in">
                    <el-table
                            class="tables"
                            border
                            :data="FamilyMemberLst"
                            align="center"
                            style="width: 100%">
                        <el-table-column
                                label="序号"
                                type="index"
                                align="center"
                                width="50">
                        </el-table-column>
                        <el-table-column
                                prop="MemberName"
                                align="center"
                                label="姓名">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.MemberName==''}"
                                          v-model="scope.row.MemberName" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Relationships"
                                label="关系">
                            <template scope="scope">
                                <el-select class="quire" :class="{'red':scope.row.Relationships==''}"
                                           v-model="scope.row.Relationships" placeholder="请选择">
                                    <el-option
                                            v-for="item in RelationshipLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="ContactPhoneNumber"
                                label="联系电话">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.ContactPhoneNumber==''}"
                                          v-model="scope.row.ContactPhoneNumber" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="ContactAddress"
                                label="联系地址">
                            <template scope="scope">
                                <el-input class="quire" :class="{'red':scope.row.ContactAddress==''}"
                                          v-model="scope.row.ContactAddress" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="IsEmergencyContact"
                                label="是否紧急联系人">
                            <template scope="scope">
                                <el-select @change="Emerge(scope.$index)" class="quire" v-model="scope.row.IsEmergencyContact" placeholder="请选择">
                                    <el-option
                                            v-for="item in options"
                                            :key="item.value"
                                            :label="item.label"
                                            :value="item.value">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Remark"
                                label="备注">
                            <template scope="scope">
                                <el-input v-model="scope.row.Remark" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="100"
                                align="center"
                                prop="address"
                                label="操作">
                            <template scope="scope">
                                <el-button type="text" @click="del('FamilyMemberLst',scope.$index)">删除</el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </div>
            </div>
        </div>
        <div class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>培训经历</p>
                <div class="add" @click="add('TrainingExperienceLst')"><i class="iconfont icon-xinzeng1"></i>添加
                </div>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap">
                <div class="count-in">
                    <el-table
                            class="tables"
                            border
                            :data="TrainingExperienceLst"
                            align="center"
                            style="width: 100%">
                        <el-table-column
                                label="序号"
                                type="index"
                                align="center"
                                width="50">
                        </el-table-column>
                        <el-table-column
                                prop="TrainingInstitutions"
                                align="center"
                                label="培训机构">
                            <template scope="scope">
                                <el-input v-model="scope.row.TrainingInstitutions" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="TrainingCourse"
                                label="培训课程">
                            <template scope="scope">
                                <el-input v-model="scope.row.TrainingCourse" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="TrainingInstructor"
                                label="培训讲师">
                            <template scope="scope">
                                <el-input v-model="scope.row.TrainingInstructor" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="TrainKind"
                                width="140"
                                label="培训类别">
                            <template scope="scope">
                                <el-select v-model="scope.row.TrainKind" placeholder="请选择">
                                    <el-option
                                            v-for="item in TrainKindLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="TrainForm"
                                width="140"
                                label="培训形式">
                            <template scope="scope">
                                <el-select v-model="scope.row.TrainForm" placeholder="请选择">
                                    <el-option
                                            v-for="item in TrainFormLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="160"
                                align="center"
                                prop="BeginDate"
                                label="开始日期">
                            <template scope="scope">
                                <el-date-picker
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.BeginDate"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="160"
                                align="center"
                                prop="EndDate"
                                label="结束日期">
                            <template scope="scope">
                                <el-date-picker
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.EndDate"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Certificate"
                                label="获取证书">
                            <template scope="scope">
                                <el-input v-model="scope.row.Certificate" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Remark"
                                label="备注">
                            <template scope="scope">
                                <el-input v-model="scope.row.Remark" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="100"
                                align="center"
                                prop="address"
                                label="操作">
                            <template scope="scope">
                                <el-button type="text" @click="del('TrainingExperienceLst',scope.$index)">删除</el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </div>
            </div>
        </div>
        <div class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>技能特长</p>
                <div class="add" @click="add('SkillLst')"><i class="iconfont icon-xinzeng1"></i>添加</div>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap">
                <div class="count-in">
                    <el-table
                            class="tables"
                            border
                            :data="SkillLst"
                            align="center"
                            style="width: 100%">
                        <el-table-column
                                label="序号"
                                type="index"
                                align="center"
                                width="50">
                        </el-table-column>
                        <el-table-column
                                width="150"
                                prop="SkillType"
                                align="center"
                                label="技能类型">

                            <template scope="scope">
                                <el-select v-model="scope.row.SkillType" placeholder="请选择">
                                    <el-option
                                            v-for="item in SkillTypeLst"
                                            :key="item"
                                            :label="item"
                                            :value="item">
                                    </el-option>
                                </el-select>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="150"
                                align="center"
                                prop="SkillLevel"
                                label="技能等级">
                            <template scope="scope">
                                <el-input v-model="scope.row.SkillLevel" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Remark"
                                label="备注">
                            <template scope="scope">
                                <el-input v-model="scope.row.Remark" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="100"
                                align="center"
                                prop="address"
                                label="操作">
                            <template scope="scope">
                                <el-button type="text" @click="del('SkillLst',scope.$index)">删除</el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </div>
            </div>
        </div>
        <div class="mes-wrap">
            <div class="tit">
                <i class="titicon iconfont icon-biaotitubiao"></i>
                <p>项目经历</p>
                <div class="add" @click="add('ProjectExperienceLst')"><i class="iconfont icon-xinzeng1"></i>添加
                </div>
                <div class="exp sq"><i class="iconfont icon-shouqi2"></i>收起</div>
                <div class="exp zk"><i class="iconfont icon-zhankai2"></i>展开</div>
            </div>
            <div class="count-wrap">
                <div class="count-in">
                    <el-table
                            class="tables"
                            border
                            :data="ProjectExperienceLst"
                            align="center"
                            style="width: 100%">
                        <el-table-column
                                label="序号"
                                type="index"
                                align="center"
                                width="50">
                        </el-table-column>
                        <el-table-column
                                prop="ProjectBrief"
                                align="center"
                                label="项目简介">
                            <template scope="scope">
                                <el-input v-model="scope.row.ProjectBrief" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="ProjectResponsibility"
                                label="项目职责">
                            <template scope="scope">
                                <el-input v-model="scope.row.ProjectResponsibility" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Accomplishments"
                                label="项目业绩">
                            <template scope="scope">
                                <el-input v-model="scope.row.Accomplishments" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="BeginDate"
                                label="开始日期">
                            <template scope="scope">
                                <el-date-picker
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.BeginDate"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="EndDate"
                                label="结束日期">
                            <template scope="scope">
                                <el-date-picker
                                        value-format="yyyy-MM-dd"
                                        v-model="scope.row.EndDate"
                                        align="right"
                                        type="date"
                                        placeholder="选择日期"
                                        :picker-options="pickerOptions">
                                </el-date-picker>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="ProjectStation"
                                label="项目职务">
                            <template scope="scope">
                                <el-input v-model="scope.row.ProjectStation" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                align="center"
                                prop="Remark"
                                label="备注">
                            <template scope="scope">
                                <el-input v-model="scope.row.Remark" placeholder="请输入"></el-input>
                            </template>
                        </el-table-column>
                        <el-table-column
                                width="100"
                                align="center"
                                prop="address"
                                label="操作">
                            <template scope="scope">
                                <el-button type="text" @click="del('ProjectExperienceLst',scope.$index)">删除</el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </div>
            </div>
        </div>

        <div class="upload">
            <label class="lab">附件:</label>
            <el-upload
                    class="upload-demo"
                    :action="url"
                    :on-preview="handlePreview"
                    :on-remove="handleRemove"
                    :before-remove="beforeRemove"
                    :before-upload="beforeUpload"
                    multiple
                    :headers="header"
                    :on-success="uploadchange"
                    :limit="10"
                    :on-exceed="limitnum"
                    :file-list="fileList">
                <el-button class="bt" size="small" type="primary"><i class="iconfont icon-shangchuanfujian"></i>点击上传</el-button>
            </el-upload>
        </div>
        <div class="bt-wrap">
            <el-button type="primary" class="bt" @click="submitmes">提交</el-button>
            <el-button class="bt" @click="saved">暂存</el-button>
        </div>
    </div>
</template>

<script>
    require("../../assets/js/Uploader.js");
    export default {
        name: 'mescollect',
        props: {},
        data() {
            return {
                header:{
                    user: "dawc"
                },
                loading:false,
                upfileList:[],
                options: [{
                    value:"1",
                    label:"是"
                },{
                    value:"0",
                    label:"否"
                }],
                pickerOptions: {
                    disabledDate(time) {
                        return time.getTime() > Date.now();
                    },
                    shortcuts: [{
                        text: '今天',
                        onClick(picker) {
                            picker.$emit('pick', new Date());
                        }
                    }, {
                        text: '昨天',
                        onClick(picker) {
                            const date = new Date();
                            date.setTime(date.getTime() - 3600 * 1000 * 24);
                            picker.$emit('pick', date);
                        }
                    }, {
                        text: '一周前',
                        onClick(picker) {
                            const date = new Date();
                            date.setTime(date.getTime() - 3600 * 1000 * 24 * 7);
                            picker.$emit('pick', date);
                        }
                    }]
                },
                rules: {
                    CandidateName: [{required: true, message: "请输入姓名",}],
                    CertificateCode: [{required: true, message: "请输入证件号码",}],
                    CertificateType: [{required: true, message: "请输入证件类型",}],
                    CertificateName: [{required: true, message: "请输入证件姓名",}],
                    Nation: [{required: true, message: "请输入民族",}],
                    Birthday: [{required: true, message: "请输入出生日期",}],
                    Gender: [{required: true, message: "请输入性别",}],
                    Email: [{required: true, message: "请输入邮箱",}],
                    MobilePhone: [{required: true, message: "请输入电话号码",}],
                    PoliticalStations: [{required: true, message: "请选择政治面貌",}],
                    NatureAccount: [{required: true, message: "请选择户口性质",}],
                    NativePlaceName: [{required: true, message: "请输入籍贯",}],
                    HouseholdAddress: [{required: true, message: "请输入户籍地址",}],
                    Address: [{required: true, message: "请输入现住址",}],
                    MaritalStatus: [{required: true, message: "请选择婚姻情况"}],
                    // FertilityStatus:[{required: true, message: "请选择生育情况",}],
                    Health: [{required: true, message: "请选择健康状况",}],
                    HighestQualification: [{required: true, message: "请选择最高学历",}],
                    WorkTime: [{required: true, message: "请选择参加工作时间",}],
                    EmergencyContact: [{required: true, message: "请输入紧急联系人",}],
                    EmergencyContactNo: [{required: true, message: "请输入紧急联系人电话",}],
                },
                BaseInfo:{
                    "CandidateName": "",
                    "CertificateCode": "",
                    "CertificateType": "",
                    "CertificateName": "",
                    "Nation": "",
                    "Birthday": "",
                    "Gender": "",
                    "Email": "",
                    "MobilePhone": "",
                    "WeChart": "",
                    "QQ": "",
                    "WageNumbers": "",
                    "PoliticalStations": "",
                    "NatureAccount": "",
                    "NativePlaceName": "",
                    "HouseholdAddress": "",
                    "Address": "",
                    "MaritalStatus": "",
                    "Health": "",
                    "HighestQualification": "",
                    "WorkTime": "",
                    "RecruitmentChannels": "",
                    "EmergencyContact": "",
                    "EmergencyContactNo": "",
                    "ISMoreThenTenYears": "",
                    "ISPaySocialSecurityInWH": "",
                    "AttachmentLst":[],
                    "IsHaveKinsfolk":"",
                    "IsHaveReferrer":"",
                    "FertilityStatus":""
                },   //基本信息
                EducationLst: [],    //教育经历
                WorkExperienceLst: [],    //工作经历
                FamilyMemberLst: [],    //家庭状况
                TrainingExperienceLst: [],    //培训经历
                SkillLst: [],    //技能特长
                CertificateTypeLst: [],    //证件类型
                NationLst: [],    //民族
                GenderLst: [],    //性别
                PoliticalStationLst: [],    //政治面貌
                NatureAccountLst: [],    //户口性质
                MaritalStatusLst: [],    //婚姻状况
                HealthLst: [],    //健康状况
                QualificationLst: [],    //学历
                DegreeLst: [],    //学位
                RecruitmentChannelsLst: [],    //招聘渠道
                SkillTypeLst: [],    //技能类型
                RelationshipLst: [],    //关系
                TrainKindLst: [],    //培训类别
                TrainFormLst: [],    //培训形式
                EducationNatureLst:[],//学历性质
                fileList:[],  //文件列表
                ProjectExperienceLst:[],
                submes: {},
                url:""
            }
        },
        methods: {
            add(type) {
                switch (type) {
                    case "EducationLst":
                        var obj = {
                            "GraduateSchool": "",
                            "Professional": "",
                            "Education": "",
                            "Degree": "",
                            "EntranceTime": "",
                            "GraduationTime": "",
                            "EducationNature": "",
                            "Remark": ""
                        };
                        this.EducationLst.push(obj);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                    case "WorkExperienceLst":
                        var obj = {
                            "CompanyName": "",
                            "PositionName": "",
                            "BeginDate": "",
                            "EndDate": "",
                            "Remark": ""
                        };
                        this.WorkExperienceLst.push(obj);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                    case "FamilyMemberLst":
                        var obj = {
                            "MemberName": "",
                            "Relationships": "",
                            "ContactPhoneNumber": "",
                            "ContactAddress": "",
                            "IsEmergencyContact": "0",
                            "Remark": ""
                        };
                        this.FamilyMemberLst.push(obj);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                    case "TrainingExperienceLst":
                        var obj = {
                            "TrainingInstitutions": "",
                            "TrainingCourse": "",
                            "TrainingInstructor": "",
                            "TrainKind": "",
                            "TrainForm": "",
                            "BeginDate": "",
                            "EndDate": "",
                            "Certificate": "",
                            "Remark": ""
                        };
                        this.TrainingExperienceLst.push(obj);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                    case "SkillLst":
                        var obj = {
                            "SkillType": "",
                            "SkillLevel": "",
                            "Remark": ""
                        };
                        this.SkillLst.push(obj);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                    case "ProjectExperienceLst":
                        var obj = {
                            "SkillType": "",
                            "SkillLevel": "",
                            "Remark": ""
                        };
                        this.ProjectExperienceLst.push(obj);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                }
            },
            del(type, index) {
                console.log(index)
                switch (type) {
                    case "EducationLst":
                        if (this.EducationLst.length > 0) {
                            this.EducationLst.splice(index, 1);
                            if(this.EducationLst.length==0){
                                this.add("EducationLst")
                            }
                        }
                        setTimeout(() => {
                            this.inits()
                        }, 50);
                        break;
                    case "WorkExperienceLst":
                        if (this.WorkExperienceLst.length > 0) {
                            this.WorkExperienceLst.splice(index, 1);
                        }
                        setTimeout(() => {
                            this.inits()
                        }, 50);
                        break;
                    case "FamilyMemberLst":
                        if (this.FamilyMemberLst.length > 0) {
                            this.FamilyMemberLst.splice(index, 1);
                            if(this.FamilyMemberLst.length==0){
                                this.add("FamilyMemberLst")
                            }
                        }
                        setTimeout(() => {
                            this.inits()
                        }, 50);
                        break;
                    case "TrainingExperienceLst":
                        this.TrainingExperienceLst.splice(index, 1);
                        setTimeout(() => {
                            this.inits()
                        }, 50);
                        break;
                    case "SkillLst":
                        if (this.SkillLst.length > 0) {
                            this.SkillLst.splice(index, 1);
                            if(this.SkillLst.length==0){
                                this.add("SkillLst")
                            }
                        }
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                    case "ProjectExperienceLst":
                        this.ProjectExperienceLst.splice(index, 1);
                        setTimeout(() => {
                            this.inits()
                        }, 50)
                        break;
                }
            },
            inits() {
                for (var i = 0; i < $(".count-wrap").length; i++) {
                    $(".count-wrap").eq(i).css({
                        height: $(".count-in").eq(i).height() + 20
                    })
                }
            },
            Emerge(index){
                if(this.FamilyMemberLst[index].IsEmergencyContact==="1"){
                    for(let i in this.FamilyMemberLst){
                        this.FamilyMemberLst[i].IsEmergencyContact="0";
                    }
                    this.FamilyMemberLst[index].IsEmergencyContact="1";
                }

            },
            formatinfo(info) {
                this.BaseInfo = info.CandidateInfo.BaseInfo;
                this.EducationLst = info.CandidateInfo.EducationLst;
                this.WorkExperienceLst = info.CandidateInfo.WorkExperienceLst;
                this.FamilyMemberLst = info.CandidateInfo.FamilyMemberLst;
                this.TrainingExperienceLst = info.CandidateInfo.TrainingExperienceLst;
                this.SkillLst = info.CandidateInfo.SkillLst;
                this.ProjectExperienceLst = info.CandidateInfo.ProjectExperienceLst;
                this.CertificateTypeLst = info.CertificateTypeLst;
                this.NationLst = info.NationLst;
                this.GenderLst = info.GenderLst;
                this.PoliticalStationLst = info.PoliticalStationLst;
                this.NatureAccountLst = info.NatureAccountLst;
                this.MaritalStatusLst = info.MaritalStatusLst;
                this.HealthLst = info.HealthLst;
                this.QualificationLst = info.QualificationLst;
                this.DegreeLst = info.DegreeLst;
                this.RecruitmentChannelsLst = info.RecruitmentChannelsLst;
                this.SkillTypeLst = info.SkillTypeLst;
                this.RelationshipLst = info.RelationshipLst;
                this.TrainKindLst = info.TrainKindLst;
                this.TrainFormLst = info.TrainFormLst;
                this.EducationNatureLst=info.EducationNatureLst;
                if(this.BaseInfo){
                    this.upfileList=this.BaseInfo.AttachmentLst;
                    for(let i in this.BaseInfo.AttachmentLst){
                        var unit={
                            name:this.BaseInfo.AttachmentLst[i].FileName,
                            url:this.BaseInfo.AttachmentLst[i].FileUrl,
                        }
                        this.fileList.push(unit)
                    }
                }


            },
            formatsub() {
                console.log(this.BaseInfo)
                var obj = {};
                obj.BaseInfo = this.BaseInfo;
                obj.BaseInfo.EntrantEmployeeID = this.$route.query.oid;
                obj.EducationLst = this.EducationLst;
                obj.WorkExperienceLst = this.WorkExperienceLst;
                obj.FamilyMemberLst = this.FamilyMemberLst;
                var TrainingExperienceLst=[];
                for(let i in this.TrainingExperienceLst){
                    console.log(this.TrainingExperienceLst[i])
                    var put=false;
                    for (let k in this.TrainingExperienceLst[i]){
                        if(this.TrainingExperienceLst[i][k]!=null&&this.TrainingExperienceLst[i][k]!=""){
                            put=true;
                        }
                    }
                    if(put){
                        TrainingExperienceLst.push(this.TrainingExperienceLst[i])
                    }
                }
                obj.TrainingExperienceLst =TrainingExperienceLst;
                var SkillLst=[];
                for(let i in this.SkillLst){
                    var put=false;
                    for (let k in this.SkillLst[i]){
                        console.log(this.SkillLst[i][k])
                        if(this.SkillLst[i][k]!=null&&this.SkillLst[i][k]!=""){
                            put=true;
                        }
                    }
                    if(put){
                        SkillLst.push(this.SkillLst[i])
                    }
                }
                obj.SkillLst = SkillLst;
                var ProjectExperienceLst=[];
                for(let i in this.ProjectExperienceLst){
                    var put=false;
                    for (let k in this.ProjectExperienceLst[i]){
                        if(this.ProjectExperienceLst[i][k]!=null&&this.ProjectExperienceLst[i][k]!=""){
                            put=true;
                        }
                    }
                    if(put){
                        ProjectExperienceLst.push(this.ProjectExperienceLst[i])
                    }
                }
                obj.ProjectExperienceLst = ProjectExperienceLst;
                obj.BaseInfo.AttachmentLst = this.upfileList;
                this.submes = obj;
            },
            saved() {
                this.formatsub();
                axios.post("Api/Common/SaveCandidateInfo", this.submes)
                    .then(res => {
                        if (res.data.success){
                            this.$message({
                                message: '信息保存成功！',
                                type: 'success'
                            });
                        }else{
                            console.log(res);
                            this.$message.error(res.data.message);
                        }
                    }).catch(error => {
                    console.log(error);
                    this.$message.error(error);
                });

            },
            submitmes() {
                this.formatsub();
                let Emerge=false;
                var re = /^[\u4e00-\u9fffa-zA-Z]{1,30}$/;
                var str =this.submes.BaseInfo.CertificateName;
                if(!re.test(str)){
                    this.$message.error('请检查证件姓名是否正确！');
                    return;
                }
                var bytesCount=0;
                for (var i = 0; i < str.length; i++)
                {
                    var c = str.charAt(i);
                    if (/^[\u0000-\u00ff]$/.test(c)) //匹配双字节
                    {
                        bytesCount += 1;
                    }
                    else
                    {
                        bytesCount += 2;
                    }
                }
                if(bytesCount>30){
                    this.$message.error('证件姓名过长,请检查证件姓名是否正确！');
                    return;
                }
                console.log(bytesCount)
                for (var i = 0; i < this.submes.FamilyMemberLst.length; i++) {
                    if (this.submes.FamilyMemberLst[i].IsEmergencyContact === "1") {
                        Emerge=true;
                        this.submes.BaseInfo.EmergencyContact = this.submes.FamilyMemberLst[i].MemberName;
                        this.submes.BaseInfo.EmergencyContactNo = this.submes.FamilyMemberLst[i].ContactPhoneNumber;
                    }
                }
                if (this.submes.BaseInfo.CertificateType=="身份证"){
                    var reg= /(^\d{15}$)|(^\d{18}$)|(^\d{17}(\d|X|x)$)/;
                    if(reg.test(this.submes.BaseInfo.CertificateCode)===false){
                        this.$message.error('身份证输入不合法');
                        return;
                    }
                }
                if(Emerge===false){
                    this.$message.error("请在<家庭状况>中添加一位紧急联系人!");
                    return;
                }

                for (var i = 0; i < $(".quire").length; i++) {
                    if ($(".quire").eq(i).find("input").val() == "") {
                        this.$message.error('有必填项还未填写！');
                        return;
                    }
                }

                var vali=true;
                this.$refs["Baseinfo"].validate((valid) => {
                    if (!valid) {
                        this.$message.error('有必填项还未填写！');
                        vali=false;
                        return;
                    }
                });

                if(!vali){return}

                this.loading=true;
                axios.post("Api/Common/SubmitCandidateInfo", this.submes)
                    .then(res => {
                        this.loading=false;
                        if (res.data.success){
                            this.$message({
                                message: '信息提交成功！',
                                type: 'success'
                            });
                            setTimeout(()=> {
                                window.location.href="https://www.mingyuanyun.com/";
                            },1000)
                        }else{
                            console.log(res);
                            this.$message.error(res.data.message);
                        }
                        
                    }).catch(error => {
                    console.log(error);
                    this.$message.error(error);
                });
            },

            getinfo() {
                var oid = this.$route.query.oid;
                this.loading=true;
                axios.get("Api/Common/GetCandidateInfoViewData", {
                    params: {
                        oid: oid
                    }
                })
                    .then(res => {
                        this.formatinfo(res.data.data)
                        if (this.EducationLst === null) {
                            this.EducationLst = [];
                            this.add("EducationLst")
                        }
                        if (this.WorkExperienceLst === null) {
                            this.WorkExperienceLst = [];
                        }
                        if (this.FamilyMemberLst === null) {
                            this.FamilyMemberLst = [];
                            this.add("FamilyMemberLst")
                        }
                        if (this.TrainingExperienceLst === null) {
                            this.TrainingExperienceLst = [];
                            this.add("TrainingExperienceLst")
                        }
                        if (this.SkillLst === null) {
                            this.SkillLst = [];
                            this.add("SkillLst")
                        }
                        if (this.ProjectExperienceLst == null) {
                            this.ProjectExperienceLst = [];
                            this.add("ProjectExperienceLst")
                        }
                        console.log(this.BaseInfo)
                        if (this.BaseInfo == null) {
                            this.BaseInfo = {
                                "CandidateName": "",
                                "CertificateCode": "",
                                "CertificateType": "",
                                "CertificateName": "",
                                "Nation": "",
                                "Birthday": "",
                                "Gender": "",
                                "Email": "",
                                "MobilePhone": "",
                                "WeChart": "",
                                "QQ": "",
                                "WageNumbers": "",
                                "PoliticalStations": "",
                                "NatureAccount": "",
                                "NativePlaceName": "",
                                "HouseholdAddress": "",
                                "Address": "",
                                "MaritalStatus": "",
                                "Health": "",
                                "HighestQualification": "",
                                "WorkTime": "",
                                "RecruitmentChannels": "",
                                "EmergencyContact": "",
                                "EmergencyContactNo": "",
                                "ISMoreThenTenYears": "",
                                "ISPaySocialSecurityInWH": "",
                                "AttachmentLst":[]
                            }
                        }
                        setTimeout(() => {
                            this.inits()
                            this.loading=false;
                        }, 30)
                    }).catch(error => {
                    console.log(error);
                    this.$message.error(error);
                });0

            },
            acceptOffer(){
                var oid = this.$route.query.oid;
                axios.get("API/Common/AcceptOffer", {
                    params: {
                        oid: oid
                    }
                })
                    .then(res => {
                        console.log(res)
                    }).catch(error => {
                    console.log(error);
                    this.$message.error(error);
                });
            },
            handleRemove(file,fileList) {
                this.fileList=fileList;
                this.reloadupload()
            },
            handlePreview(file) {
                var url=file.url?file.url:file.response.data;
                setTimeout(function () {
                    const $a = document.createElement('a');
                    $a.setAttribute("href", url);
                    $a.setAttribute("download", "");
                    var evobj=document.createEvent("MouseEvents");
                    evobj.initMouseEvent("click",true,true,window,0,0,0,0,0,false,false,true,false,0,null);
                    $a.dispatchEvent(evobj)
                },50)
            },
            reloadupload(){
                var arr=[];
                for(let i in this.fileList){
                    var unit={
                        FileName:this.fileList[i].name,
                        FileUrl:this.fileList[i].url?this.fileList[i].url:this.fileList[i].response.data
                    }
                    arr.push(unit)
                }
                this.upfileList=arr;
            },
            beforeRemove(file, fileList) {
                return true;
            },
            beforeUpload(file){
                if(file.size>5242880){
                    this.$message.error("上传文件不得大于5MB");
                    return false;
                }
            },
            uploadchange(res,file, fileList){
                this.fileList=fileList;
                this.reloadupload()
            },
            limitnum(){
                this.$message.error("上传文件个数不得超过10个");
            }
        },
        mounted() {
            this.url=process.env.VUE_APP_BASEURL+"API/Common/UploadAttachment";
            $(".sq").click(function () {
                $(this).parent().parent().find(".count-wrap").css("height", "0");
                $(this).parent().find(".zk").css("display", "block");
                $(this).css("display", "none")
            })

            $(".zk").click(function () {
                $(this).parent().parent().find(".count-wrap").css({
                    height: $(this).parent().parent().find(".count-wrap").find(".count-in").height() + 10
                });
                $(this).parent().find(".sq").css("display", "block");
                $(this).css("display", "none")
            })

            this.getinfo()
            this.acceptOffer()
        }
    }
</script>

<style lang="scss" scoped>
    .mescollect {
        width: 1330px;
        height: auto;
        position: relative;
        margin: auto;
        padding-bottom: 80px;
        .red{
            color: red;
        }
        .iconfont{
            color: #009FFF;
        }
        .mes-wrap {
            width: 100%;
            height: auto;
            position: relative;
            margin-top: 40px;
            .count-wrap {
                overflow: hidden;
                padding-bottom: 10px;
                transition: 0.5s;
            }
            .tables {
                margin-top: 20px;
            }
            .tit {
                width: 100%;
                height: 50px;
                display: flex;
                justify-content: left;
                background-color:rgba(0,159,255,0.1);
                .titicon{
                    font-size: 22px;
                    line-height: 46px;
                    margin-left: 12px;
                    margin-right: 12px;
                }
                p {
                    font-family: PingFangSC-Semibold;
                    font-size: 16px;
                    color: #009FFF;
                    line-height: 50px;
                }
                .exp {
                    width: 80px;
                    height: 30px;
                    position: absolute;
                    top: 10px;
                    right: 20px;
                    border-radius: 3px;
                    text-align: center;
                    line-height: 30px;
                    cursor: pointer;
                    color: #2693F2;
                    i {
                        font-size: 14px;
                        line-height: 30px;
                        position: relative;
                        top: 1px;
                        margin-right: 5px;
                    }
                }
                .add {
                    width: 80px;
                    height: 30px;
                    position: absolute;
                    top: 10px;
                    right: 90px;
                    border-radius: 3px;
                    text-align: center;
                    line-height: 30px;
                    cursor: pointer;
                    color: #2693F2;
                    i {
                        font-size: 14px;
                        line-height: 30px;
                        position: relative;
                        top: 1px;
                        margin-right: 5px;
                    }
                }
                .zk {
                    display: none;
                    i{
                        transform: rotateZ(90deg);
                    }
                }
            }
        }
        .count {
            display: flex;
            justify-content: space-between;
            flex-wrap: wrap;
        }
        .input-group {
            width: 20%;
            margin-top: 20px;
        }
        .count2 {
            display: flex;
            justify-content: start;
            flex-wrap: wrap;
            .input-group {
                width: 25%;
            }
        }
        .count3 {
            justify-content: left;
        }
        .bt-wrap {
            margin-top: 30px;
            .bt {
                width: 150px;
                margin: 50px;
            }
        }
    }
</style>
<style lang="scss">
    .mescollect {
        font-size: 13px;
        .red {
            border: red;
            input {
                border-color: red;
            }
        }
        .el-form-item {
            height: 40px;
            margin: 0;
        }
        .el-date-editor.el-input, .el-date-editor.el-input__inner {
            width: 98%;
            position: relative;
            left: 2px;
        }
        .inp-wrap {
            width: calc(100% - 2px);
            display: flex;
            flexDirection: "row";
            margin-top: 20px;
            label {
                line-height: 40px;
                padding: 0 15px;
                box-sizing: border-box;
                word-break: keep-all; /* 不换行 */
                white-space: nowrap; /* 不换行 */
                font-size: 14px;
            }
            .lab1{
                width: 100px;
                text-align: left;
            }
            .lab2{
                width: 133px;
                text-align: left;
            }
            .el-form-item{
                flex-grow: 1;
            }
            .el-input {
                flexGrow: 1;
                input {
                    border: 1px solid #ccc;
                }
            }
            .el-input--suffix .el-input__inner{
                padding-right: 15px;
            }
        }
        .upload{
            display: inline-block;
            width: 290px;
            margin-top: 50px;
            vertical-align: top;
            position:relative;
            text-align: left;
            left: -34%;
            .lab{
                margin-right: 15px;
                vertical-align: top;
                position: absolute;
                top: 6px;
                left: -50px;
            }
            .bt{
                background: #FFFFFF;
                border: 1px solid #009FFF;
                border-radius: 4px;
                color:#009FFF;
                i{
                    margin-right: 5px;
                    font-size: 14px;
                }
            }
        }
        .upload-demo{
            display: inline-block;
            width: 300px;
            height: 32px;
        }

    }
</style>