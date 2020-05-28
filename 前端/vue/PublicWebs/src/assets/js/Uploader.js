//formData 可写,可不写，但最好尽量提供，为了后续扩展支持业务
var Uploader = function (options) {
    this.Init = function (params) {
        //文档开始
        if (!params.uploadConfigDomain) { alert("请输入属性[uploadConfigDomain]"); return; }
        if (!params.userID) { alert("请输入属性[userID]"); return; }
        if (!params.userName) { alert("请输入属性[userName]"); return; }

        var UploadConfigDomain = params.uploadConfigDomain;
        var index = UploadConfigDomain.indexOf(".") + 1;
        //document.domain = UploadConfigDomain.substring(index);

        var upload = params && params.callback && params.callback.success ? params.callback.success : null;
        var error = params && params.callback && params.callback.error ? params.callback.error : null;
        var deleteFile = params && params.callback && params.callback.deleteFile ? params.callback.deleteFile : null;

        var parameters = {
            pick: {
                id: params.id, label: (params.label) ? params.label : '上传'  //上传按钮ID,显示文字
            },
            hideFileList: params && params.hideFileList,
            formData: {
                BusinessFileID: params.BusinessFileID ? params.BusinessFileID : '', //修改时 文件服务器的文件唯一编号
                state: params.state ? params.state + '' : '0',  //0单选1多选
                userID: params.userID, //上传人ID
                userName_Chn: params.userName, //上传人名称
                ProductCode: params.ProductCode ? params.ProductCode : 'HR', //产品code
                ProductName: params.ProductName ? params.ProductName : 'HR管理系统', //产品名称
                FileBllType: params.FileBllType ? params.FileBllType : '', //文档类型
                FileData: params.FileData ? params.FileData : ''     //自定义数据
            },
            isDuplicate: true,

            accept: params && params.accept ? params.accept : {
                title: 'doc,docx,xls,xlsx,ppt,pptx,txt,pdf,zip,rar,jpg,png',//flash版时文件标题
                extensions: 'doc,docx,xls,xlsx,ppt,pptx,txt,pdf,zip,rar,jpg,png',//flash版时文件类型过滤
                mimeTypes: 'application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document,application/vnd.ms-excel,application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,' +
                        'application/vnd.ms-powerpoint,application/vnd.openxmlformats-officedocument.presentationml.presentation,text/plain,application/pdf,application/x-zip-compressed,application/x-rar-compressed,image/*' //html5版时文件过滤
            },
            Domain: UploadConfigDomain
        };
        //指定提交URL
        if (params && params.postUrl) {
            $.extend(parameters, { postUrl: params.postUrl });
        }
        new UploadAttachment(parameters, upload, error, deleteFile);
    }
    //执行初始化
    this.Init(options);
}