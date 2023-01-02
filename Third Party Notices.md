This package contains third-party software components governed by the license(s) indicated below:

---



## Vuforia Developer Agreement

VUFORIA™ DEVELOPER AGREEMENT

 

Effective: December 8, 2022

 

THIS VUFORIA DEVELOPER AGREEMENT (THIS “AGREEMENT” OR THIS “Agreement”) IS A LEGALLY BINDING AGREEMENT BETWEEN PTC INC. ("PTC") AND THE LEGAL ENTITY YOU REPRESENT (“YOU” OR “You”). IF YOU USE OR ARE SEEKING TO USE THE SOFTWARE OR SERVICES DISCUSSED HEREIN IN CONNECTION WITH ANY WORK OR UNDERTAKING YOU ARE DOING FOR A BUSINESS, COMPANY OR CORPORATE ENTITY (“COMPANY”), WHETHER AS AN EMPLOYEE OR CONTRACTOR, THE TERMS “YOU” AND “YOU” INCLUDE, AND THE TERMS AND CONDITIONS HEREOF ARE BINDING ON, BOTH YOU AS AN INDIVIDUAL AS WELL AS SUCH COMPANY. IN ADDITION, YOU REPRESENT AND WARRANT THAT YOU HAVE THE AUTHORITY TO BIND SUCH COMPANY, AND THAT SUCH COMPANY HAS AUTHORIZED YOU TO ACCEPT THE TERMS OF THIS AGREEMENT ON ITS BEHALF.

 

PTC IS WILLING TO PROVIDE YOU THE SERVICES (AS DEFINED BELOW) AND LICENSE TO YOU THE SOFTWARE AND DOCUMENTATION (AS DEFINED BELOW) ONLY ON THE CONDITION THAT YOU ACCEPT AND AGREE TO ALL OF THE TERMS AND CONDITIONS IN THIS AGREEMENT. YOU ACKNOWLEDGE AND AGREE THAT YOU HAVE READ THIS AGREEMENT, UNDERSTAND IT AND AGREE TO BE BOUND BY ITS TERMS AND CONDITIONS. IF YOU DO NOT AGREE TO THESE TERMS AND CONDITIONS, PTC IS UNWILLING TO AND DOES NOT AND WILL NOT LICENSE THE SOFTWARE AND DOCUMENTATION OR PROVIDE THE SERVICES TO YOU. IF YOU DO NOT AGREE TO THESE TERMS AND CONDITIONS YOU MAY NOT COMMENCE ANY INSTALLATION PROCESS AND YOU SHALL NOT USE THE SOFTWARE OR RETAIN ANY COPIES OF THE SOFTWARE OR DOCUMENTATION, EVEN IF YOU HAVE IN ANY MANNER COME INTO POSSESSION THEREOF. ANY USE OR POSSESSION OF THE SOFTWARE, SERVICES, AND/OR DOCUMENTATION BY YOU IS SUBJECT TO THE TERMS AND CONDITIONS SET FORTH IN THIS AGREEMENT, INCLUDING WITHOUT LIMITATION THE FEES DUE FOR SUCH USE OR POSSESSION. PTC MAY SUSPEND OR TERMINATE YOUR USE OF THE SOFTWARE, DOCUMENTATION, SERVICES, AND/OR STATISTICS IF YOU FAIL TO COMPLY WITH ANY PART OF THIS AGREEMENT.

 

You may not use the Software, Documentation, or Services and may not accept this Agreement if You are a person barred from receiving the Software, Documentation and/or Services under the laws of the United States or any other country including the country in which You are resident or in which You use the Software.

 

The Software is licensed to You on a per-application basis. The type of license required is determined by the type of application You are developing. You are permitted to use the Software at no cost to develop Your application by utilizing a free Development License. In order to deploy Your application, You are required to obtain a License in accordance with the Vuforia Pricing Schedule. For Premium Licenses (see Section 2.4) you must contact PTC for a License at https://developer.vuforia.com/contact-sales [2].

 

1. DEFINITIONS. As used in this Agreement or the Vuforia Pricing Schedule (as defined below), the following terms shall have the following meanings:

 

(a) “Area Targets” means a Target that is created from the 3D scan of an environment using a supported 3D scanner in the Area Target Generator, Area Target Creator and/or Area Target Capture API.

 

(b) “Area Target Capture API” means an API that enables your application to capture and generate Area Targets at runtime and use them instantly to augment environments.

 

(c) “Area Target Generator” means a desktop application intended for the creation of Area Targets from a supported capture scanning device.

 

(d) “Authorized Contractor” means a contractor engaged by You who (a) has an active and valid Vuforia Developer Account with PTC, (b) has a demonstrable need to know or use the Software and Service in order to develop and test the Developer Application, and (c) has a written and binding agreement with You to protect the unauthorized use and disclosure of Confidential Information (as defined in Section 6 below).

 

(e) “Camera View” or “camera view” means an image from a device’s camera viewfinder screen that is automatically captured by the Developer Application and provided to the Software or the Cloud Recognition Services.

 

(f) “Cloud-Based Reco” or “cloud-based reco” means a Recognition of a Cloud Target.

 

(g) “Cloud Target” or “cloud target” means a Target that is stored in the cloud using the Cloud Recognition Service as opposed to on the end-user device.

 

(h) “Cloud Target Database” means the database containing Targets that is accessed by the Cloud Recognition Service.

 

(i) “Cloud Recognition Service” means the cloud-based image recognition and image management service as made available by PTC for use in connection with Developer Applications.

 

(j) “Content” means Targets and other data (including, but not limited to, text, graphics, images, photographs, video, sounds, and other digital assets) that You provide PTC through the VWS APIs and/or the Target Manager for use with Developer Applications.

 

(k) “Developer Application” means a software application that is developed by You or on Your behalf hereunder using the Software and Services. All current versions and all future versions of such software application across all operating systems (e.g. Android, iOS, Universal Windows Platform etc.) that have the same name (or a minor variation of the name) and have substantially similar functionality shall be considered to be a single Developer Application under this Agreement.

 

(l) “Development Tool” has the meaning set forth in Section 2.3 (Development Tool) below.

 

(m) “Device-Based Reco” or “device-based reco” means the recognition of Targets stored in a Target Database on the end-user’s device.

 

(n) “Documentation” means the documentation that PTC or its affiliates provide or otherwise makes available to You in connection with the Software and Services.

 

(o) “Engine Developer Portal” means the Vuforia online developer portal located at https://developer.vuforia.com [3] (or such other URL as PTC may designate from time to time) that includes, without limitation, the Target Manager, the License Manager, the Vuforia Forums, the Vuforia Support Center and access to the Software, Documentation, and other related information.

 

(p) “Engine Developer Portal Support Center” means the support center available through the Engine Developer Portal where developers may gain access to non-technical support (e.g., support regarding billing and other account issues).

 

(q) “License” means one of the development or deployment plans available to developers using the Software and Services, as further described (i) at https://developer.vuforia.com/pricing [4], or such other URL as PTC may designate from time to time or (ii) in an order confirmation, written agreement, or quote.

 

(r) “License Key” means a unique key specific to a particular Developer Application that enables the use of the Software in the Developer Application.

 

(s) “License Manager” means the Vuforia License Manager web application available through the Engine Developer Portal where You may request and manage License Keys.

 

(t) “Model Target” means a Target that is created from a 3D model in the Model Target Generator.

 

(u) “Model Target Generator” means a desktop application intended for the creation of 3D model Targets.

 

(v) “Permitted Use” has the meaning set forth in Section 2.7 (Permitted Use) below.

 

(w) “Query” means a request to use the Cloud Recognition Services sent by the Developer Application and contains a Camera View.

 

(x) “Recognition” or “recognition” or “reco” is a transaction event that is registered by the Software when any Target is recognized successfully as reported by PTC’s system.

 

(y) “Sample Application” means an application (i.e., apk file(s)) provided hereunder in compiled binary form as a sample for the purposes of demonstrating certain features enabled by the Software.

 

(z) “Sample Code” means sample code provided hereunder in source code (human readable) form for the purposes of demonstrating certain features enabled by the Software.

 

(aa) “Sample Target Files” means sample Targets and other sample Content for use with Sample Applications or in testing and development of Developer Applications.

 

(bb) “Services” means the Vuforia system and services made available to You by PTC for use in connection with Developer Applications, which may include, without limitation, the services available through the Engine Developer Portal, the VWS API, the Cloud Recognition Services, and other related features and functionality of the Vuforia platform.

 

(cc)  “Software“ means the software described in the list in Section 3.1 (License to Software other than Sample Code), and additional software, if any, that PTC provides pursuant to Section 3.7 (Additional Software).

 

(dd) “Software Update” means a major version update of the Software and Services that PTC makes generally available. The major version is designated by the integer to the left of the leftmost decimal in the version release number. For example, Vuforia 7.0.1 is a Software Update to Vuforia 6.5.3, but Vuforia 7.1.5 is not a Software Update to Vuforia 7.0.2.

 

(ee) “Target” or “target” means an image or set of images (including, without limitation, a set of markers), VuMarks, Model Targets, or Area Targets that are recognizable by the Software.

 

(ff) “Target Database” means a database of one or more Targets associated with a particular Developer Application.

 

(gg) “Target Manager” means the Vuforia Target Manager web application available through the Engine Developer Portal used to manage Your Targets and other Content.

 

(hh) “Unity” means the cross-platform gaming and video development platform developed by Unity Technologies and found at https://unity3d.com [5] and related websites.

 

(ii) “Vuforia Application(s)”means a mobile application made available to You from time to time, in compiled binary form.

 

(jj) “Vuforia Engine” means the binary files encapsulated in the Software, and any related scripts and content contained as part of the SDK package.

 

(kk) “Vuforia Pricing Schedule” means the pricing for the Services Plans set forth (i) at https://www.ptc.com/en/products/vuforia/vuforia-engine/pricing [6] or such other URL as PTC may designate from time to time or (ii) in a written agreement or quote.

 

(ll) “VuMark” means the .svg, .png, or .pdf file that is created with the VWS APIs or the Target Manager.

 

(mm)   “VuMark Designer” means the Vuforia scripts that are used by You to create a VuMark Template.

 

(nn) “VuMark Generation Service” means the cloud-based service used to generate a VuMark from a VuMark Template, whether accessed through the Target Manager or VWS APIs.

 

(oo) “VuMark Template” means the .svg file that is created by You using the VuMark Designer. The VuMark Template defines the encoding scheme and visual design used.

 

(pp) “VWS API” means the Vuforia Web Services APIs for (i) cloud target provisioning, (ii) cloud recognition, and (iii) VuMark generation.

 

2. LICENSE TYPES AND USES. Except as otherwise permitted herein, You are required to procure a License for each Developer Application you create with the Software and Services. The type of License required is determined by the type of Your Developer Application.

 

(a) Basic Plan. A Basic Plan allows You to generate and deploy an unlimited number of Developer Applications using the Basic Plan features described at https://www.ptc.com/en/products/vuforia/vuforia-engine/pricing [7]. . A Basic Plan License Key is required for any Developer Application in the development process that makes use of the Target Manager. To deploy the Premium features specified at https://www.ptc.com/en/products/vuforia/vuforia-engine/pricing [6] in a Developer Application, You are required to purchase a Premium Plan, otherwise, such features may not be deployed in a Developer Application. The Basic Plan includes the support set forth in Section 2.13 and Software Updates.

 

(b) Cloud Add-ons. The Cloud Add-ons enable Your Developer Application to connect to a Target Database and perform Cloud Recognition Services.

 

(c) Development Tool. A Development Tool is a software application that is used by You, Your employees, or Your end-users to create a Developer Application or prepare, author or publish content for use with a Developer Application. Development Tools may include engines, software development kits, libraries, authoring tools, and middleware.

 

(d) Premium Plan. A Premium Plan allows You to generate and deploy an unlimited number of Developer Applications using the Premium Plan features described at https://www.ptc.com/en/products/vuforia/vuforia-engine/pricing [6]. A Premium Plan License Key is required to deploy Developer Applications that use such features. You are required to contact PTC at https://developer.vuforia.com/contact-sales [2] to purchase a Premium License, which is licensed under a separate agreement.

 

(e) Independent Software Vendor Application. An Independent Software Vendor Application is a Developer Application that is offered on a subscription basis and uses features included in the Premium Plan. You are required to contact PTC at https://developer.vuforia.com/contact-sales [2] to purchase a License for an independent software vendor application.

 

(f) License Keys. You acknowledge and agree that each Developer Application and Cloud Target Database must use a unique License Key. PTC may, in its sole discretion decline to provide You License Keys or access to the Software, for any reason or no reason. PTC has the right to monitor Your Developer Application(s) and use of the License Key(s) to ensure they are not employed except for the Permitted Use. If employed for other than the Permitted Use, PTC has the right to immediately revoke the License Key(s) and Your License to the Software. You shall not sell, transfer or sublicense Your License Keys to any person or entity.

 

(g) Permitted Use. As more particularly described in the Documentation, the Software and Services are intended for use as Development Tools to enable the testing, development and distribution of visual recognition end-user software applications in accordance with the applicable License associated with the Developer Application (the “Permitted Use”). Subject to and conditioned upon compliance with the terms and conditions of this Agreement, including the limitations, conditions, restrictions, and obligations set forth below, PTC hereby permits You to use and access the Software and/or Services during the term of this Agreement solely for the Permitted Use. You are responsible for compliance with any applicable laws governing access to and provision of the Services in Your Developer Application(s). Notwithstanding the foregoing, PTC reserves the right to modify the Services with or without notice.

 

(h) Engine Developer Portal. Any access to or use of the Engine Developer Portal shall be subject to this Agreement as well as the PTC website terms of use located at https://developer.vuforia.com/legal/tos [8] (or such other URL as PTC may designate from time to time) (the “TOS”) and the privacy policy located at https://www.ptc.com/en/documents/policies/privacy [9] (or such other URL as PTC may designate from time to time) (the “Privacy Policy”).

 

(i) Cloud Recognition Services. You acknowledge that each Developer Application that integrates the Cloud Recognition Services must contain application logic that, upon receipt of notification from the Software or the Cloud Recognition Services indicating that the Software and/or the Cloud Recognition Services have been upgraded, prompts the end-user of the Developer Application to install an updated release of the Developer Application that integrates the latest version of the Vuforia Engine. Your permission to access the Cloud Recognition Services is limited solely for the purpose of storage and retrieval of Targets and other Content to enable cloud-based image recognition functionality as integrated in Developer Application(s). Developer Application(s) shall access the Cloud Recognition Services solely via the Software and/or the VWS APIs. You shall upload Cloud Targets solely via the VWS APIs and/or the Target Manager. You acknowledge that PTC or its affiliates may, with or without prior notice to You, change, discontinue or deprecate any VWS APIs for the Cloud Recognition Services from time to time and any such modification may require You to change or update Developer Application(s).

 

(j) Account Credentials. You are solely responsible for maintaining the confidentiality of Your password protected access to the Services. Except as set forth below, You shall not distribute Your password or otherwise allow third parties to access the password protected features of the Services using Your password. You may share your account credentials, including Your password, with a contractor for the sole purpose of assisting You in developing and testing a Developer Application on Your behalf provided that such contractor (a) has an active and valid Vuforia developer account with PTC and an active agreement with PTC similar to these terms governing the contractor’s access to and use of the Software and Services, (b) has a need to access Your account to assist in developing and testing the Developer Application, and (c) has a written and binding agreement with You to protect the unauthorized use and disclosure of Confidential Information (as defined in Section 6 (Confidentiality)). You are responsible for maintaining appropriate security, protection, and backup for Your user account, Targets and other Content and License Keys and for all activities that occur under or are otherwise associated with Your account. You shall notify PTC immediately of any unauthorized use of any License Keys or any other known or suspected breach of security of Your user account or License Keys.

 

(k) Targets. You understand and agree that the Services and Software may allow You to store Targets and other Content on servers located in the United States and in other countries. You also understand and agree that the Services and Software may allow You to retrieve database file(s) containing Targets and other Content from such servers. You hereby acknowledge and accept that the servers may be owned, managed, or controlled by PTC, or one of its affiliates or service providers, and You agree that PTC and its affiliates and service providers may use, modify, reproduce and distribute the Targets and other Content to provide the Services and to improve the Services, the Software and other products, services and technologies of PTC and its affiliates without attribution or compensation.

 

(l) Bug Reports. You are encouraged to report to PTC all bugs You experience or encounter with the Software or any component of the Services provided hereunder, and You agree that PTC shall have the right to use and exploit commercially, without attribution or compensation to You, all feedback (of any nature) which PTC receives from You, in any form, to improve, enhance or modify the Software, services or otherwise.

 

(m) Limited Support. During the term of this Agreement, if You have purchased a License, you may submit a support request on the Engine Developer Portal Support Center. You acknowledge and agree, however, that PTC is under no obligation to provide any form of technical support for the Services, Software and/or Documentation, and that if PTC, in its sole discretion, chooses to provide any form of support or information relating to the Services, Software and/or Documentation, such support and information shall be provided “AS IS” and shall be deemed confidential and proprietary to PTC and protected in accordance with Section 6 (Confidentiality) unless otherwise specified in writing. You are responsible for providing customer service to end-users of the Developer Application(s). PTC will not provide any support to end-users of the Developer Application(s).

 

(n) Limitations on Use of Service. You are responsible for configuring and complying with all Services requirements and instructions to ensure normal operation and use of the Services by or through the Developer Application(s) and/or Your systems that interface with the Developer Application(s). You will comply with terms and conditions for the Services as provided in writing from time to time if any. Except as otherwise expressly permitted herein, You agree not to sublicense, transfer, assign, share, sell, resell, rent, lease, lend, or otherwise provide access to Your developer account or any Services or the Software provided therewith, in whole or in part, to anyone. For the avoidance of doubt, You agree not to create or attempt to create a tool for creating computer vision applications or a substitute or similar service through the use of or access to the Services or Software. You shall not reverse engineer or access any part of the Services in order to (a) build or offer a competitive product or service, (b) build or offer a product using similar ideas, features, or functions of all or any part of the Services, or (c) copy any ideas, features, or functions of the Services or Software. You shall not attempt to gain unauthorized access to the Services or its related systems or networks. You shall not excessively use the overall network capacity or bandwidth of the Services or otherwise burden the Services with unreasonable data loads (including, without limitation, a Developer Application that incurs an excessive number of unsuccessful Queries). You agree not to harm or interfere with PTC’s networks or servers or any third-party networks or servers connected to the Services or otherwise disrupt other users’ use of the Services. You shall abide by all applicable local, state, national, and foreign laws, treaties, and regulations in connection with Developer Application(s) and Your use of the Services, including without limitation those related to privacy and data collection, international communications, and the transmission, and storage of technical or personal data. You understand there may be storage capacity, transmission, and/or transactional limits for the Services both for You as a developer and for Your end-users. If You reach or Your end-user reaches such limits, then You or Your end-user may be unable to use the Services or may be unable to access or retrieve data from such Services. Such limits may be based on Your License or may be based on device type, design of the Developer Application, Target design or other factors.

 

(o) Right to Modify, Suspend or Terminate Service. Notwithstanding any remedies that may be available under any applicable law and without limiting PTC’s right to terminate the Services or this Agreement under Section 12 (Term and Termination), PTC may temporarily or permanently deny, limit, suspend, or terminate Your access to and use of all or any portion of the Services or Software without penalty, with or without notice, if PTC believes, in its sole discretion, that: (a) You breached this Agreement, including without limitation any failure to pay amounts when due; or(b) Your user account has been compromised or has been inactive for more than 12 months; or (c) Your user account information is or becomes inaccurate or incomplete; or (d) You have performed any act or omission that violates any applicable law, rules, or regulations; or (e) You have performed any act or omission which is harmful or likely to be harmful to PTC, the Services, the Software, or any other third party, including other users or suppliers of PTC; or (f) You made use of the Services or Software to perform an illegal act, or for the purpose of enabling, facilitating, assisting or inducing the performance of such an act; or(g) PTC has insufficient rights to provide the Services or the Software, or the terms under which the Services or Software may be made available impose upon PTC terms or risks that are not reasonably acceptable to PTC or its affiliates. If PTC suspends the License for nonpayment or other breach by You, monthly or annual fees and usage fees would still apply until You or PTC cancels the applicable License. PTC reserves the right to modify its Documentation and policies relating to the Services and Software at any time, effective upon posting of an updated version of such policies on the Engine Developer Portal. You are responsible for regularly reviewing the Documentation and policies. Continued use of the Services after any such changes will constitute Your consent to such changes.

 

3. LICENSE GRANT.

 

(a) License to Software other than Sample Code. Subject to and conditioned upon compliance with the terms and conditions of this Agreement, including the limitations, conditions, restrictions and obligations set forth below, PTC hereby grants to You a personal, non-exclusive, non-sublicensable (except as expressly provided in Section 3.6 (Limited Sublicense Rights)), non-transferable, revocable, limited copyright license, during the term of this Agreement solely for the Permitted Use, to (i) download, install and use the Software (other than Sample Code) in machine-readable (i.e. object code) form, and (ii) distribute in object code only the Vuforia Engine that is included in the Software, solely as such binary files are integrated into and used by each Developer Application in accordance with the Documentation and the terms of this Agreement. In addition to any additional software that PTC provides pursuant to Section 3.7 (Additional Software), the Software licensed hereunder may include the following:

 

• Vuforia Applications
• Area Target Capture API
• Area Target Generator
• Model Target Generator
• Sample Code (licensed under Section 3.4)
• Sample Target Files
• Sample and Test Applications
• VuMark Designer Scripts
• VuMark Generation Service
• Vuforia Software Development Kit
• Vuforia Engine (redistributable as permitted above)

The contents of the Software may vary for platform-specific versions.

 

(b) Documentation. Subject to the terms and conditions of this Agreement, including the limitations, conditions, restrictions, and obligations set forth below, You may reproduce and use a reasonable number of copies of the Documentation on an internal basis only, and solely in support of Your Permitted Use of the Software. Distribution of the Documentation is prohibited without the express written permission of PTC.

 

(c) Third Party Licenses. The Software may contain third party programs, including but not limited to software licensed under open source terms. The license terms associated with those programs apply to Your use of them, and in some instances, such programs cannot be used or further distributed without a license from the respective owner of such programs. You shall be solely responsible to (i) obtain, if necessary, a separate and independent license from such owner with respect to any such use and (ii) include all applicable license terms and notices in the Developer Application for third party programs contained in the Software that is distributed as part of the Developer Application. The delivery of the Software does not convey a license, nor imply any rights, to use third party programs. A separate and independent license for such use may be required and You shall be solely responsible to verify whether such license is needed in conjunction with Your use of such third-party programs.

 

(d) License to Sample Code. PTC may, in its sole discretion, provide You with certain Sample Code. In some cases, the Sample Code may be delivered to You separately from the other Software, but whether provided separately or together with the other Software, if (and only if) PTC provides such Sample Code to You, then subject to and conditioned upon compliance with the terms and conditions of this Agreement, including the limitations, conditions, restrictions, and obligations set forth below, PTC hereby grants to You a personal, non-sublicensable, non-transferable, non-exclusive, revocable, limited copyright license, during the term of this Agreement, solely for the Permitted Use, to modify the Sample Code, compile into object code the Sample Code and Your modifications thereto, and reproduce and distribute such compiled object code as part of the Developer Application, in each case strictly in accordance with the Documentation and the Permitted Use. You acknowledge and agree that Your license to the Sample Code is conditioned upon You modifying the Sample Code such that Your software application contains material additional features and functionality. Re-distribution of Sample Code without material improvement is not permitted. You will inform any third parties that are to receive such software applications that contain any Sample Code or Your modifications thereto that the delivery of such software applications will not convey or otherwise provide any rights under patents of PTC or any of its affiliates or Licensors.

 

(e) License to Vuforia Applications. PTC may, in its sole discretion, provide certain Vuforia Applications. In some cases, a Vuforia Application may be delivered to You separately from the other Software, but whether provided separately or together with the other Software, if (and only if) PTC provides such Vuforia Application to You, then subject to the terms and conditions of this Agreement, including the limitations, conditions, restrictions, and obligations set forth below, PTC hereby grants to You a personal, non-sublicensable, non-transferable, non-exclusive, revocable, limited copyright license, during the term of this Agreement, to install such Vuforia Application on a reasonable number of wireless devices, solely for the Permitted Use. PTC reserves the right to modify, suspend or stop providing any or all Vuforia Applications with or without notice, and may terminate Your access to any or all Vuforia Applications for any reason.

 

(i) Sample Applications. The Sample Applications are provided “AS IS” and for the sole purpose of demonstrating certain features enabled by the Software.

 

(ii) Benchmarking. You are not permitted to perform any benchmarking of the Software, Services, or any other Vuforia Applications, including but not limited to, monitoring service availability, performance or functionality, or for any other competitive purposes.

 

(f) Limited Sublicense Rights.

 

(i) End-Users. Subject to and conditioned upon compliance with the terms and conditions of this Agreement, including the limitations, conditions, restrictions and obligations set forth above and below, PTC hereby grants to You a personal, non-sublicensable, non-transferable (unless permitted by PTC in writing), non-exclusive, revocable, limited copyright license, during the term of this Agreement to sublicense the Vuforia Engine and/or Sample Code, solely as an integral part of Your Developer Application and solely to licensed recipients of Your Developer Application, subject to the following additional requirements: (a) Your Vuforia-enabled Developer Application(s) must add significant functionality to the Vuforia Engine andSample Code, as applicable, and You shall not distribute the Vuforia Engine and/or Sample except as fully integrated into the Developer Application(s), (b) Your sublicense must be no less protective of the Software and the rights and interests of PTC and its affiliates than are the terms of this Agreement, including but not limited to the restrictions set forth in Sections 4.1, (c) You shall not make any representations, warranties, or undertake (or attempt to undertake) any obligations on behalf of PTC or its affiliates, (d) You shall ensure that PTC and its affiliates shall have no liability to Your sublicensees, (e) have purchased the applicable License (d) You shall have the right to terminate any sublicense immediately without notice, if PTC terminates Your right to use the Software and/or Services

 

(ii) Contractor Sublicense. Subject to and conditioned upon Your compliance with the terms and conditions of this Agreement, including, without limitation, the limitations, conditions, restrictions and obligations set forth herein, PTC hereby grants to You a personal, non-exclusive, non-sublicenseable, nontransferable (unless otherwise permitted by PTC in writing), revocable, limited copyright license, during the Term to sublicense the license rights set forth in Sections 3.1 (License to Software other than Sample Code), 3.2 (Documentation), 3.4 (License to Sample Code), and 3.5 (License to Vuforia Applications) solely to Your Authorized Contractors for the sole purpose of developing and/or distributing Developer Applications on Your behalf, provided that (i) any sublicense rights granted to any such Authorized Contractor by You pursuant to this Section 3.6.2 may be granted on a single tier basis only, without further sublicense rights; (ii) You own the Developer Application(s) developed (exclusive of the Software) or have obtained all intellectual property rights licenses necessary to allow such Authorized Contractor to perform such development and/or distribution, (iii) the Developer Application(s) developed and/or distributed by such Authorized Contractors on Your behalf comply with the terms and conditions of this Agreement; (iv) Your Contractor has registered on the Engine Developer Portal as a Vuforia developer and has clicked-through to signify their acceptance of the terms of this Agreement; and (v) You shall be responsible and liable for the acts and omissions of Your Authorized Contractors, including without limitation, their compliance with this Agreement, as if such acts or omissions were Your own acts or omissions.

 

(g) Additional Software. PTC hereby reserves the right to provide or otherwise make available, at its discretion, additional software to You from time to time. Any additional software or documentation that PTC provides to You by express reference to this Agreement will be considered to be part of the Software or Documentation, as the case may be, and subject to all terms and conditions of this Agreement. By accepting, possessing or using such additional software or documentation, which shall include without limitation any related plug-ins as we may directly or indirectly distribute as well as related web applications used to generate image resources, You agree that the terms of this Agreement will apply thereto.

 

(h) Pre-commercial Software Releases. If the Software provided to You under this Agreement is designated by PTC as a pre-commercial release (indicated by terms such as “early access,” “alpha,” “beta,” “trial,” “draft”, “evaluation” or “labs”) then in lieu of the licenses granted to You above, but subject to any other executed agreement that You may have for the Software which grants additional or different rights or imposes additional or different restrictions, You shall only have the right under this Agreement to download and install the Software on a reasonable number of workstations for the internal and non-commercial evaluation of the Software. You acknowledge that the Software is a prerelease or experimental version and is not at the level of performance and compatibility of a final product. The Software may not operate correctly and may be substantially modified prior to first commercial release, or may be withdrawn completely. You will not do any significant development or testing using the Software, and any development You undertake is at Your sole risk, with the understanding that the Software may never be issued for commercial use. You shall not commercialize, distribute, publicly perform or publicly display any applications developed by You using the Software or any component thereof. If You desire other rights (such as the right to develop commercial products using the Software) You must use a commercial release of the Software. The use license granted in this section expires when the Software is made available under full commercial terms which You accept or upon notice to You by PTC, whichever is earlier.

 

(i) Retention of Rights. PTC and its affiliates and licensors hereby retain all right, title, and interests in and to the Software, Services, and any other software provided to You by PTC hereunder, including without limitation all copyrights, patent rights, trademark rights, and all other intellectual property rights therein or related thereto. Subject to ownership rights of PTC, its affiliates, and licensors in and to the Software and Services, You shall retain the copyright rights in and to any modifications to the source code portions of the Software that are made by You as permitted by this Agreement. You hereby retain all right, title, and interest in and to the Targets and Content. If You disclose or otherwise provide to PTC or its affiliates any modifications to the Software, You hereby grant and agree to grant to PTC, a non-exclusive, perpetual, irrevocable, worldwide, transferable, royalty-free license (with rights to sublicense) to make, use, sell, reproduce, modify, perform, display and distribute such modifications to the Software, either alone or as part of PTC’s or its affiliates’ products. This Agreement does not convey or otherwise provide to You and PTC retains title or any ownership rights or interests in or to any intellectual property rights of PTC or any of its affiliates, including but not limited to (1) those incorporated in the Software or any component of the Software, or (2) any patents, patent applications, works of authorship, trade secrets, know-how, ideas, or any other subject matter protectable under intellectual property rights laws of any jurisdiction, of PTC or any of its affiliates (including, but not limited to, PTC). Any rights not expressly granted to You herein are hereby reserved by PTC. In addition, You acknowledge and agree, on behalf of Yourself and Your affiliates, that (a) this Agreement does not modify or abrogate any obligations that You or any of Your affiliates has under any license or other agreement with PTC, including without limitation any obligation to pay any fees and/or royalties.

 

4. RESTRICTIONS

 

(a) Software Use Restrictions. Except as expressly provided in Section 3 (License Grant) above, You may make a single copy of the Software only for backup purposes, provided that You reproduce all copyright and other proprietary notices that are on the original copy of the Software. You may not disable, remove, hide, disfigure or otherwise modify any copyright notices, watermarks, or other proprietary notices generated by the Software. You shall not, nor shall You authorize or permit any third party to, incorporate, link, distribute or use any third-party software or code in conjunction with (i) the Software (ii) any software, products, documentation, content or other materials developed using the Software, nor (iii) any derivative works that You make using the source code portions of the Software (if any), in such a way that: (a) creates, purports to create or has the potential to create, obligations with respect to the Software or other PTC software, including without limitation the distribution or disclosure of any source code; or (b) grants, purports to grant, or has the potential to grant to any third party any rights to or immunities under any intellectual property rights or proprietary rights of PTC or its affiliates or Licensors, including without limitation as such rights exist in or relate to the Software. Without limiting the generality of the foregoing, You shall not incorporate, link, distribute or use (1) the Software or any other software provided by PTC, (2) any software, products, documentation, content or other materials developed using the Software, nor (3) any derivative works that You make using the source code portions of the Software (if any), with any code or software licensed under any version of the GNU General Public License (“GPL”), Affero General Public License (“AGPL”), Lesser General Public License (“LGPL”), European Union Public License (“EUPL”), Apple Public Source License (“APSL”), Common Development and Distribution License (“CDDL”), IBM Public License (“IPL”), Eclipse Public License (“EPL”), Mozilla Public License (“MPL”), or any other open source license, in any manner that could cause or could be interpreted or asserted to cause the Software, other PTC software (or any modifications thereto), or the patents of PTC or those of its licensors to become subject to the terms of the GPL, AGPL, LGPL, EUPL, APSL, CDDL, IPL, EPL, MPL, or any other Open Source License. You, and each party receiving Software or any copies thereof from You, shall not receive any rights to use such Software or copies thereof in a manner that will cause any patents, copyrights or other intellectual property rights which are owned or controlled by PTC or any of its affiliates (or for which PTC or any of its affiliates has received license rights) to become subject to any encumbrance or terms and conditions of any third party or open source license (including, without limitation, any open source license listed on http://www.opensource.org/licenses/alphabetical [10]) (each an “Open Source License”). These restrictions, limitations, exclusions and conditions shall apply even if PTC or any of its affiliates becomes aware of or fails to act in a manner to address any violation or failure to comply therewith. Also, no act by PTC or any of its affiliates that is undertaken under this Agreement as to any software or technology shall be construed as being inconsistent with the intent not to cause any patents, copyrights or other intellectual property rights which are owned or controlled by PTC or any of its affiliates (or for which PTC or any of its affiliates has received license rights) to become subject to any encumbrance or terms and conditions of any Open Source License.

 

(b) Additional Restrictions. You will not: (i) reverse engineer, disassemble, decompile, or translate the Software, or otherwise attempt to derive the source code version of the Software, except if and only to the extent expressly permitted by applicable law; (ii) use the Software and/or Documentation or any portion thereof to create or develop any developer tools (including without limitation plug-ins and middleware) or any software other than end-user targeted software applications; (iii) make more copies of the Software and/or Documentation than specified in this Agreement or allowed by applicable law, despite this limitation; (iv) except as expressly permitted hereby, rent, lease, loan or otherwise in any manner provide or distribute the Software and/or Documentation or any copy of thereof to any third party; (v) access or use for any purpose any application protocol interface (API) such as the Vuforia APIs, except as expressly described in the Documentation; or (vi) except as expressly permitted under Section 3 (License Grant), reproduce, distribute, publicly perform, publicly display or create derivative works of or based on the Software and/or Documentation, or disclose, provide or otherwise transfer, in any manner, to any third party the Software (except as expressly permitted for the Sample Code), Documentation or any portion thereof. You agree to not use any tools or methods other than the Target Manager, the VWS API, Model Target Generator, Area Target Generator, Vuforia Applications, and/or Area Target Capture API, and VuMark Generation Services for the purpose of generating Targets for image and 3D object recognition and tracking for use with Developer Applications. You agree not to programmatically script elements of the Engine Developer Portal web user interface. Any Developer Applications that You create or develop using the Software shall not access any third-party service for the purpose of image recognition (other than the Vuforia image recognition Services made available by PTC or its affiliates under this Agreement).

 

(c) Distribution of Developer Applications. You are strictly prohibited from publishing or otherwise distributing any Developer Applications to any third party unless (i) such publication or other distribution complies with the terms of this Agreement; (ii) such publication or distribution complies with any third party agreement terms applicable to the development and distribution of the Developer Application (e.g., the iOS, Universal Windows Platform, and/or Android platform and marketplace agreements); and (iii) You own or have secured all intellectual property rights necessary to distribute the Developer Application.

 

(d) License to Targets & Target Restrictions.

 

(i) You grant PTC and its affiliates and service providers a worldwide, non-exclusive, royalty-free, and transferable license to use, reproduce, distribute, prepare derivative works of, display and perform the Targets and other Content in connection with the Services and Software and as set forth in Section 2.10 (Targets) and Section 10 (Consent to Collection and Use of Data). You, not PTC, shall have sole responsibility for the accuracy, quality, integrity, legality, reliability, appropriateness, intellectual property ownership, and right to use of all Targets and other Content. You represent and warrant that You have obtained all necessary permission and licenses from all holders of intellectual property rights, if any, in material or code appearing, used, or recorded in any Developer Application that You create or develop with the Software and/or Documentation. Without limiting the foregoing, You represent and warrant that You have all rights necessary to send the Targets and other Content to the Services and use and authorize others to use the Targets and other Content in connection with the Services and Developer Application and that all Targets and other Content will comply with all applicable laws and regulations. For the avoidance of doubt, as between You and PTC, PTC holds all ownership rights in and to VuMark Templates. With respect to the Model and Area Targets, Customer retains ownership rights Content or Targets being scanned with such applications, including any images, logos or trademarks contained therein.

 

(ii) PTC shall not be responsible or liable for the availability, usability, deletion, correction, destruction, damage, loss or failure to store any Targets or other Content. You will not include in Developer Applications any Targets, other Content or any materials of any kind that (a) are infringing, obscene, threatening, defamatory, libelous, violative of third party privacy rights, or otherwise unlawful or tortious, (b) contain software viruses, worms, Trojan horses, or other harmful computer code, files, scripts, agents, or programs, (c) interfere with or disrupt the integrity or performance of the Service or the data contained therein or (d) contain any facial recognition functionality or facial images.

 

(iii) PTC reserves the right, upon reasonable cause, to withhold, remove, and/or discard any Target or other Content without notice. For purposes of the foregoing, “reasonable cause” includes, without limitation, (1) PTC’s determination that the Target or other Content subjects PTC to any actual or potential harm or other liability or (2) Your failure to comply with the terms of the Agreement or pay any amounts owed PTC if any. PTC assumes no obligation to monitor the Targets and other Content to determine if there is reasonable cause to remove any Targets or other Content.

 

(e) Violation Notice. If You become aware of any violations of this Agreement associated with You and/or any Developer Application, including without limitation any violation of Sections 4.4.2(a) – (d) above, then You will: (i) provide prompt written notice to PTC of such violation and (ii) immediately terminate the access giving rise to the violation.

 

5. FEES AND PAYMENT. You agree to pay the applicable fees and amounts for use of the Software and Services set forth in the Vuforia Pricing Schedule (the “Fees”) in accordance with the terms of this Agreement, including, without limitation, Exhibit 1 (Payment Terms). Fees and amounts for any new feature of the Service will be effective when posted unless expressly stated otherwise. Increased or new fees for the existing features of the Service will be effective no less than thirty (30) days after such increased or new fees are posted in the Vuforia Pricing Schedule. For the avoidance of doubt, if You don’t agree to the new fees you may terminate this Agreement at any time as set forth in Section 12.2 (Termination without Cause).

 

6. CONFIDENTIALITY. You hereby acknowledge and agree that the Services and any information relating to the Services (including without limitation any information regarding Service availability, performance, benchmarking, confidential business terms or the like), the Software (excepting the Sample Code in object/binary form), the Documentation, and related information and communications from PTC which are designated as confidential or proprietary (“Confidential Information”) are the confidential and proprietary information of PTC. Except as expressly permitted in this Agreement, You shall not disclose, or permit the disclosure of, the Confidential Information in any form to any third party without PTC’s prior written permission; provided that, You may otherwise generally make mention of and discuss the Services and Software with others. Without limiting the generality of the foregoing, any data and analytics provided by PTC to You are Confidential Information, and You are bound by the terms of confidentiality set forth herein to not disclose and to use reasonable efforts to prevent the disclosure of, any such information to any third party. All data and analytics are provided to You for its internal forecasting and accounting purposes regarding Service usage only and may not be used for any other purpose. You further acknowledge and agree that any unauthorized use or disclosure of the Confidential Information may cause irreparable harm and significant injury to PTC that would be difficult to ascertain or quantify; accordingly, You agree that PTC shall have the right to seek and obtain injunctive or other equitable relief to enforce the terms of this Agreement and without limiting any other rights or remedies that PTC may have.

 

7. DISCLAIMER OF WARRANTIES. YOU EXPRESSLY ACKNOWLEDGE AND AGREE THAT THE USE OF THE SERVICES, SOFTWARE, DOCUMENTATION, AND STATISTICS (IF ANY) IS AT YOUR SOLE RISK. THE SERVICES, SOFTWARE, DOCUMENTATION, STATISTICS (IF ANY), AND TECHNICAL SUPPORT (IF ANY) ARE PROVIDED "AS IS" AND WITHOUT ANY WARRANTIES OF ANY KIND, WHETHER EXPRESS, IMPLIED, STATUTORY, OR OTHERWISE. TO THE MAXIMUM EXTENT PERMITTED UNDER APPLICABLE LAW, PTC AND ITS AFFILIATES, LICENSOR(S), AND SERVICE PROVIDER(S) (FOR THE EASE OF REFERENCE IN SECTIONS 7 (DISCLAIMER OF WARRANTIES), 8 (LIMITATION OF LIABILITY), AND 9 (INDEMNITY), PTC AND ITS AFFILIATES, LICENSOR(S) AND SERVICE PROVIDER(S) SHALL BE COLLECTIVELY REFERRED TO AS PTC) EXPRESSLY DISCLAIM ALL WARRANTIES, WHETHER EXPRESS, IMPLIED, STATUTORY OR OTHERWISE, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NONINFRINGEMENT. PTC DOES NOT REPRESENT OR WARRANT THAT THE FUNCTIONS CONTAINED IN THE SERVICES OR SOFTWARE WILL MEET YOUR REQUIREMENTS, OR THAT THE OPERATION OF THE SERVICES OR SOFTWARE WILL BE SECURE, TIMELY, UNINTERRUPTED OR ERROR-FREE, OR THAT THE SERVICES OR SOFTWARE WILL OPERATE IN COMBINATION WITH ANY OTHER HARDWARE, SOFTWARE, SYSTEM, OR DATA; OR THAT THE SOFTWARE OR SERVICES WILL ALWAYS BE AVAILABLE, OR THAT THE SERVICES, SOFTWARE OR THE SERVER(S) THAT MAKE THE SOFTWARE AND SERVICES AVAILABLE WILL BE FREE OF VIRUSES OR OTHER HARMFUL COMPONENTS; OR THAT DEFECTS IN THE SERVICES, SOFTWARE OR DOCUMENTATION WILL BE CORRECTED. FURTHERMORE, PTC DOES NOT WARRANT OR MAKE ANY REPRESENTATIONS REGARDING THE USE, OR THE RESULTS OF THE USE, OF THE SERVICES, SOFTWARE, DOCUMENTATION, OR STATISTICS (IF ANY) IN TERMS OF ITS CORRECTNESS, ACCURACY, RELIABILITY, OR OTHERWISE. NO ORAL OR WRITTEN INFORMATION OR ADVICE GIVEN BY PTC OR ITS AUTHORIZED REPRESENTATIVES SHALL CREATE ANY REPRESENTATION OR WARRANTY OR IN ANY WAY INCREASE THE SCOPE OF ANY EXPRESS WARRANTY. SOME JURISDICTIONS DO NOT ALLOW THE EXCLUSION OF IMPLIED WARRANTIES, SO THE ABOVE EXCLUSION MAY NOT APPLY OR MAY BE LIMITED.

 

8. LIMITATION OF LIABILITY. TO THE MAXIMUM EXTENT PERMITTED UNDER APPLICABLE LAW, UNDER NO CIRCUMSTANCES, SHALL PTC, ITS AFFILIATES, OR ANY OF THEIR RESPECTIVE DIRECTORS, OFFICERS, EMPLOYEES, OR AGENTS BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, PUNITIVE, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING BUT NOT LIMITED TO ANY DAMAGES FOR LOSS OF BUSINESS PROFITS, BUSINESS INTERRUPTION, LOSS OF BUSINESS INFORMATION AND THE LIKE) ARISING OUT OF OR IN CONNECTION WITH THIS AGREEMENT OR ANY DOWNLOAD, INSTALLATION OR USE OF, OR INABILITY TO USE, THE SERVICES, SOFTWARE AND/OR DOCUMENTATION, EVEN IF PTC HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES. SOME JURISDICTIONS DO NOT ALLOW THE LIMITATION OR EXCLUSION OF LIABILITY FOR INCIDENTAL OR CONSEQUENTIAL DAMAGES SO THE ABOVE LIMITATION OR EXCLUSION MAY NOT APPLY OR MAY BE LIMITED. IN NO EVENT SHALL PTC’S TOTAL AGGREGATE LIABILITY FOR ANY AND ALL DAMAGES, LOSSES, CLAIMS, AND CAUSES OF ACTIONS (WHETHER IN CONTRACT, TORT, INCLUDING NEGLIGENCE OR OTHERWISE) EXCEED ONE HUNDRED DOLLARS ($100) OR THE EQUIVALENT THEREOF IN ANY OTHER CURRENCY. THE LIMITATIONS SET FORTH IN THIS SECTION 8 (LIMITATION OF LIABILITY) SHALL APPLY NOTWITHSTANDING THE FAILURE OF THE ESSENTIAL PURPOSE OF ANY LIMITED REMEDIES SET FORTH IN THIS AGREEMENT. IF APPLICABLE LAW PRECLUDES PTC FROM DISCLAIMING A PARTICULAR KIND OF DAMAGE OR TO CAP THE LIABILITY FOR CERTAIN TYPES OF ACTIONS OR CLAIMS, THEN THE ABOVE PROVISIONS WILL BE DEEMED AMENDED TO CONFORM WITH APPLICABLE LAW, AND THE BALANCE OF THIS SECTION 8 (LIMITATION OF LIABILITY) SHALL REMAIN IN FULL FORCE AND EFFECT. THE PARTIES HAVE FULLY CONSIDERED AND FIND REASONABLE THE FOREGOING ALLOCATION OF RISK, AND THE FOREGOING LIMITATIONS IN THIS SECTION 8 (LIMITATION OF LIABILITY) ARE AN ESSENTIAL BASIS OF THE BARGAIN BETWEEN THE PARTIES.

 

9. INDEMNITY. If an application is written by You using any component of the Software and such application is used, distributed, or otherwise deployed, then You agree to indemnify and hold PTC, its affiliates and each of their respective officers, directors, employees and successors and assigns (each, a “PTC Indemnitee”) harmless from and against any and all claims, demands, causes of action, losses, liabilities, damages, costs and expenses, incurred or otherwise suffered by each PTC Indemnitee (including but not limited to costs of defense, investigation and reasonable attorney’s fees) arising out of, resulting from or related to (i) any use, reproduction or distribution of the Software, as modified or integrated by You, or any Targets or other Content, which causes an infringement of any patent, copyright, trademark, trade secret, or other intellectual property, publicity or privacy right of any third parties arising in any jurisdiction anywhere in the world, except and solely to the extent such infringement is caused by the unmodified Software, or portions thereof, as supplied to You by PTC under this Agreement, (ii) the download, distribution, installation, storage, execution, use or transfer of such software, products, documentation, content, materials or derivative works by any person or entity, (iii) Your use of the Services, and/or (iv) any breach of this Agreement by You. If and as requested by PTC, You agree to defend each PTC Indemnitee in connection with any third-party claims, demands, or causes of action resulting from, arising out of or in connection with any of the foregoing.

 

10. CONSENT TO COLLECTION AND USE OF DATA. You understand and agree that the Software sends to PTC and/or its affiliates and service providers certain technical and related information, including but not limited to the information listed at https://developer.vuforia.com/legal/statistics [11] (collectively “Statistics”). PTC will use commercially reasonable efforts to update this list with any material changes with each new commercial release of the Software, if applicable. It is your responsibility to review this list with each new release. In the event that PTC makes any Software available that contains material variances from what is set forth in this Section 10 and/or at https://developer.vuforia.com/legal/statistic [11]with respect to the collection, use, or management of “personal data” and/or “personally identifiable information” (as those terms are defined under applicable law), You will be required to consent to such variances before downloading the applicable Software. If You do not consent to such variances, do not download the Software. You further understand and agree that PTC and/or its affiliates and service providers may collect and use Statistics: (a) to provide the Software and Services, (b) to improve and optimize the Software and Services for different hardware and software requirements on various consumer devices (commonly referred to as device fragmentation), (c) to facilitate the provision of new products, updates, enhancements, technologies, and other services, (d) to improve the Software, the Services, and other products, services and technologies of PTC or its affiliates, and for any business purpose if de-identified and/or anonymized.

 

11. MANDATORY END-USER LICENSE AGREEMENT CLAUSE. 11 MANDATORY END-USER LICENSE AGREEMENT CLAUSE. You are responsible for all use of the Service and Software by end-users of the Developer Applications. Each end-user of a Vuforia-enabled software application must agree to the end user terms set forth in this Section 11. If You are licensing the Developer Application(s) directly to end-users, then You must include the following terms in Your end user license agreement for each of Your Vuforia-enabled applications. If You are developing the Developer Application(s) for a third party where such third party will, directly or indirectly, license the application(s) to end-users, then You must require such third party to include the following terms in the applicable end user license agreement. In all cases, each such end user license agreement must contain legally enforceable provisions whereby:

 

(a) each end user consents to the collection, storage, and use by PTC and its affiliates and service providers of Statistics and, if applicable, Camera Views from the Software and the transfer of Statistics (and Camera Views if applicable) between PTC and its affiliates and service providers (which may be in the United States or in other countries), in each case for the purposes of (a) providing the Software and Services, (b) facilitating the provision of new products, updates, enhancements and other services, (c) improving the Software, the Services, and other products, services and technologies, and (c) providing new products, services or technologies customers of PTC or its affiliates; and

 

(b) each end-user is advised of the hazards of using a camera-based application while driving, walking, or otherwise by being distracted or disoriented from real world situations; and

 

(c) if the Developer Application uses any portion of the Cloud Recognition Services, each end user agrees not to use the Developer Application to capture Camera Views that comprise, constitute, or depict profanity, nudity, pornographic images or explicit sexual themes, or defamatory or libelous statements, material that infringes the intellectual property of any person or entity, material that infringes upon the privacy or data protection rights of any person, or material considered illegal or objectionable. In addition, the end-user must agree not to provide or submit facial images, except if and to the extent that they have obtained the legally-binding consent of the subject in advance, provided that such consent must be documented by the Developer Application and must be sufficient to permit PTC and its affiliates and service providers to collect, store, use and transfer such images as described in this Agreement; and

 

(d) End users are subject to the provisions of Section 4.1 and 4.2 of this Agreement.

 

12. TERM AND TERMINATION.

 

(a) Term. The term of this Agreement shall commence on the date You accept this Agreement and shall remain in effect until terminated as provided herein.


(b) Termination without Cause. You may terminate the Agreement at any time by deleting and destroying all copies of the Software and all related information in Your possession or control, provided that You also inform PTC in writing at that time of such termination. You may cancel a License at any time as set forth in Section II (Cancellation) in Exhibit 1 (Payment Terms). Additionally, PTC may at any time terminate this Agreement or any License, either with or without cause, upon thirty (30) days prior written notice to You.

 

(c) Termination for Cause. PTC shall have the right to immediately terminate this Agreement or any License upon notice in the event that You fail to comply with any provision hereof. Immediately upon notice to You, PTC shall have the right to terminate this Agreement and all rights and licenses granted by PTC hereunder if You or Your affiliates assert any claims or rights by commencing or causing to be commenced any action or proceeding that alleges infringement by PTC or its affiliates of Your (or Your affiliates) intellectual property rights based on the Vuforia products and services.

 

 

(d) Effects of Termination. Upon termination of the Agreement, (i) the Services will no longer be available to You or any end users of the Developer Application(s), (ii) You must delete or destroy all copies of the Software and Documentation that are in Your possession or otherwise under Your control, and (iii) the license and other rights granted to You in this Agreement shall terminate. You acknowledge and agree that PTC has no obligation to retain any Targets or any other Content following termination of a License or this Agreement, as applicable, and that PTC may delete the Targets and other Content immediately upon termination of the applicable Service or the Agreement.

 

(e) Survival. Sections 3.9 (Retention of Rights), 6 (Confidentiality), 7 (Disclaimer of Warranties), 8 (Limitation of Liability), 9 (Indemnification), 12 (Term and Termination), 13 (Export Compliance Assurance), 14 (Compliance with Anti-Corruption Laws), and 16 (General) shall survive any termination of this Agreement, and You shall, within a reasonable time after such termination, pay any amounts that became due to PTC prior to such termination.

 

13. EXPORT COMPLIANCE ASSURANCES. You acknowledge that all Software and Documentation obtained from PTC are subject to the US government export control and economic sanctions laws. You agree not to directly or indirectly export, re-export, transfer or release any Software or Documentation or direct product thereof to any destination, person, entity, or end use prohibited or restricted under US law without prior US government authorization to the extent required by regulation. The US government maintains embargoes and sanctions against the countries listed in Country Groups E:1/2 of the EAR (Supplement 1 to part 740), currently, Cuba, Iran, North Korea, Sudan and Syria but any amendments to these lists shall apply. You agree not to directly or indirectly employ any Software or Documentation received from PTC in missile technology, sensitive nuclear or chemical biological weapons activities, or in any manner knowingly transfer any Software or Documentation to any party for any such end use. You represent and warrant that You are not listed on any U.S. Government list of prohibited or restricted parties including the US Treasury Department’s list of Specially Designated Nationals. You acknowledge that other countries may have trade laws pertaining to import, use, export, or distribution of Software and Documentation, and that compliance with same is Your responsibility.

 

14. COMPLIANCE WITH ANTI-CORRUPTION LAWS. You represent and warrant to PTC that, in connection with the transactions contemplated by this Agreement or in connection with any other business transactions involving PTC, You, and everyone acting on its behalf, will comply with and will not violate any anti-corruption law or international anti-corruption standards, including but not limited to the U.S. Foreign Corrupt Practices Act. You represent and warrant to PTC that You have not, and covenant and agree that you will not, in connection with the transactions contemplated by this Agreement or in connection with any other business transactions involving PTC, make, promise, or offer to make any payment or transfer anything of value, directly or indirectly, to any individual to secure an improper advantage. It is the intent of the parties that no payments or transfer of value shall be made which have the purpose or effect of public or commercial bribery, acceptance of or acquiescence in extortion, kickbacks, or other unlawful or improper means of obtaining or retaining business.

 

15. PUBLICITY

 

(a) Use of PTC Name and Logos. Software made available under certain Licenses include a watermark Vuforia logo that is required to be displayed in the user interface of the Developer Application pages that interact with or otherwise include the Software even when deployed. The display of the watermark in the Developer Application is subject to PTC’s branding guidelines and any additional license terms or conditions provided to You by PTC or its affiliates. You may request the branding guidelines by sending a request to vuforia-feedback@ptc.com [12]. Additionally, You may include the Vuforia mark and product description in a press release for the Developer Application provided such use has received prior written approval by PTC; and You must provide a copy of Your press release to PTC in an email sent to press-releases@ptc.com [13] at least seventy-two (72) hours in advance of issuing the press release. PTC reserves the right to reject any such press release and require You to remove all Vuforia marks and product descriptions from any such press release prior to issuance. Except as explicitly permitted in this Section, You shall not display or make any use of PTC’s or its affiliates’ names, marks or logos in connection with the Developer Application without the prior written approval of PTC. Any use of the Vuforia logos or marks that does not fully comply with the logo usage guidelines and this Agreement is prohibited.

 

(b) Use of Graphical Assets. PTC may, at its sole discretion, provide additional promotional and/or marketing opportunities with respect the Developer Application. You agree that PTC and its affiliates may include Your name (or Company’s name) and the graphical assets, screenshots, logos, brand assets, trademarks and other digital assets and information about You or the publisher that You use with or in the Developer Application or otherwise associate with the Developer Application (the “Graphical Assets”): (a) on the website of PTC or any of its affiliates or on other Vuforia-related website(s) (whether hosted by PTC, its affiliates or a third party), (b) in PTC’s list of Service-enabled applications, (c) in the Vuforia App Gallery, and (d) in other marketing and promotional material.

 

(c) Demonstration of Developer Applications by PTC. If a Developer Application is made available for download or distribution, then from and as of such date as You submit such Developer Application for, or otherwise permit or enable, such download or distribution, You hereby grant PTC and its affiliates a world-wide, assignable, non-exclusive, fully paid-up and royalty-free, perpetual right and license to use, reproduce, distribute, publicly display and publicly perform, in each case for promotional and/or demonstration purposes, each such application and accompanying documentation and Graphical Assets. Any such use by PTC or its affiliates under the above terms shall be subject to payment of any applicable standard download, subscription or use fees otherwise generally applicable to the Developer Application when accessed by the general public, but otherwise any agreement, terms or conditions for such Developer Application shall be superseded by this section, and shall be inapplicable to the promotional and/or demonstration of the Developer Application(s) as described above. You may terminate the license You grant in this Section 15.3 on not less than thirty (30) days’ prior written notice to PTC, provided that such notice references this Agreement, clearly identifies the affected Developer Application(s), and states that You wish to terminate the license granted under this Section 15.3 with respect to such Developer Applications.

 

16. GENERAL

 

(a) Government End Users. If You are acting on behalf of an agency or instrumentality of the U.S. government, the Software and Documentation, as applicable, are "commercial computer software" and "commercial computer software documentation" developed exclusively at private expense by PTC. Pursuant to FAR 12.212 or DFARS 227.7202 and their successors, as applicable, use, reproduction and disclosure of the Software is governed by the terms of this Agreement.

 

(b) Governing Law; Venue. This Agreement is governed and interpreted in accordance with the laws of the Commonwealth of Massachusetts, United States of America, without giving effect to its conflict of laws provisions that would result in the application of the laws of a different state or country. The United Nations Convention on Contracts for the International Sale of Goods is expressly disclaimed and shall not apply. Except as set forth in Section 16.3 (Dispute Resolution), any claim, lawsuit or proceeding arising out of or related to this Agreement must be brought exclusively in the courts of the Commonwealth of Massachusetts and You hereby consent to the exclusive jurisdiction and venue of such courts, provided that either party may seek injunctive or other equitable relief in any court with jurisdiction. If any provision (or portion of a provision) of this Agreement shall be held to be illegal, invalid, or unenforceable, the legality, enforceability or validity of the remaining provisions (or portion of the applicable provision) of this Agreement shall not be affected.

 

(c) Dispute Resolutions. If You are an individual or entity whose official place of residency or formation is outside of the United States, all disputes, controversies, or claims arising out of, relating to or in connection with this Agreement including the determination of the scope of the Agreement to arbitrate, shall be finally settled by arbitration in accordance with the Arbitration Rules of the United Nations Commission on International Trade Law (“UNCITRAL”), applicable at the time of submission of the dispute to arbitration, and the following shall apply:

 

16.c.1 The American Arbitration Association, ("AAA") shall be the Appointing Authority and shall appoint a single arbitrator. The arbitration case shall be administered by the AAA in accordance with its "Procedures for Cases Under the UNCITRAL Arbitration Rules" ("Rules"). The place of arbitration shall be San Diego, California, and the exclusive language to be used for the arbitral proceedings shall be English.

 

16.c.2 Nothing herein will prevent PTC, prior to the appointment of the arbitrator, from making application to any court of competent jurisdiction, for any provisional remedy available at law or in equity. Such application for relief shall not constitute a waiver of this Agreement to arbitrate. Upon appointment, the arbitrator shall have exclusive authority to order provisional or interim relief, except that any relief ordered by the arbitrator may be immediately and specifically enforced by a court otherwise having jurisdiction. You waive objection to venue and consent to the personal jurisdiction of the federal courts of Boston, Massachusetts, U.S.A. in any action to enforce this Agreement to arbitrate or any order or award of the arbitrator, or for the provisional or interim remedies provided for herein.

 

16.c.3 Discovery shall be limited to written requests for the production of specific documents. The period for requesting documents shall be sixty (60) days commencing upon the day that the answer is due under the Rules. The responding party shall have thirty (30) days to produce the requested documents by sending copies to the requesting party or its representative via a recognized international courier service. Each party will also voluntarily produce all documents that they intend to use at the arbitration hearing and a list of intended witnesses before the close of discovery subject to supplementation for purposes of rebuttal or good cause shown. Each party hereby waives any right to seek any discovery not provided for in this Agreement irrespective of whether the laws of any country provide for different or additional discovery in international arbitration. The arbitrator will hold a pre-hearing conference within three days of the close of discovery and will schedule and hold the final hearing within thirty (30) days of the close of discovery. YOU HEREBY AGREE THAT THE ARBITRATION PROCEDURE PROVIDED HEREIN WILL BE THE SOLE AND EXCLUSIVE METHOD OF RESOLVING ANY OF THE AFORESAID DISPUTES, CONTROVERSIES, OR CLAIMS.

 

(d) Amendment. Except to the extent that PTC is expressly precluded by applicable law, PTC further reserves the right to make changes to this Agreement, including but not limited to as needed to reflect changes in business practices or to reflect changes in or required by law or otherwise, by providing You with reasonable notice of the changes, which notice may be sent in writing or electronically or which may be made by posting notice of such update at https://developer.vuforia.com/legal/vuforia-developer-agreement [14]. You will be responsible for reviewing and becoming familiar with any and all such changes. In order to continue using the Software and Services, You must accept and agree to the new terms. If You do not agree to such new or modified terms, then You shall terminate this Agreement by providing timely written notice to PTC in accordance with Section 12 (Term and Termination). PTC may terminate this Agreement, effective immediately upon notice, or may suspend Your rights to use the Software and Services if You fail to accept any new Agreement terms. Except as set forth in this Section 16.4, this Agreement may be modified only by a written amendment executed by both You and PTC.

 

(e) Third Party Rights. Excepting the terms and rights applicable to PTC’s affiliates as expressly stated herein (which terms and rights such PTC affiliates shall be entitled to enforce as third party beneficiaries), the parties agree, and confirm their mutual intention, that neither this Agreement nor any of the terms of this Agreement will be enforceable by any person/entity not a direct party to it and no third party beneficiary rights are conferred on any such third party. Notwithstanding that any term of this Agreement may be or may become enforceable by a person who is not a party to this Agreement, the terms and conditions of this Agreement may be modified or amended, or this Agreement may be suspended, canceled, rescinded, or terminated by the parties as provided in Section 16.4 (Amendment) without the consent of any such third party.

 

(f) Relationship of Parties. The relationship between You and PTC created under this Agreement is non-exclusive and that of independent contractors. This Agreement shall not establish any relationship of partnership, joint venture, employment, franchise, or agency between the parties. Neither party shall have the power to bind the other or incur obligations on the other’s behalf without the other’s prior written consent.

 

(g) Notices. All notices, consents, waivers, and other communications intended to have legal effect under this Agreement must be in writing and must be in English. You agree that PTC may provide written notice under this Agreement having binding legal effect by sending an email to the email address You provided during the registration process or subsequently updated by You in accordance with this section or by posting such notice on the Engine Developer Portal. Without limiting the foregoing, You agree that any notice PTC sends to the email address associated with Your user account will satisfy any legal notice requirement. Notices sent to PTC by You shall be sent by registered or certified mail, return receipt requested, to PTC Inc., General Counsel, 121 Seaport Blvd, Boston, MA 02210, and shall be effective upon receipt by PTC. PTC may change its address for receipt of notices by giving notice of the new address to You.

 

(h) Waiver. Neither a course of dealing nor the failure of either party to require performance by the other party of any provision of this Agreement shall affect the full right to require such performance at any time thereafter; nor shall the waiver by either party of a breach of any provision of this Agreement be taken or held to be a waiver of the provision itself.

 

(i) Severability. If any provision of this Agreement is unenforceable or invalid under any applicable law or is so held by applicable court decision, such unenforceability or invalidity shall not render this Agreement unenforceable or invalid as a whole, and such provision shall be changed and interpreted so as to best accomplish the objectives of such unenforceable or invalid provision within the limits of applicable law or applicable court decisions; provided, however, that if the parties are unable to so change the provision, then the affected party may terminate this Agreement upon thirty (30) days’ notice.

 

(j) Assignment. You shall not assign or attempt to assign this Agreement, in whole or in part, without PTC’s prior written consent. Any purported assignment of this Agreement without PTC’s consent shall be void. PTC may freely assign this Agreement or delegate any or all of its rights or obligations hereunder to any third party.

 

(k) Force Majeure. PTC shall not be in default of its obligations to the extent its performance is delayed or prevented by causes beyond its control, including but not limited to acts of God, acts of You, acts of third parties not under PTC’s control, acts of any governmental body, war, insurrection, sabotage, armed conflict, embargo, fire, flood, strike or other labor disturbance, interruption of or delay in transportation, unavailability of or interruption or delay in telecommunications or third-party services, virus attacks or hackers, failure of third party software (including, without limitation, ecommerce software, payment gateways, chat, statistics or free scripts) or inability to obtain raw materials, supplies, or power used in or equipment needed for the provision of Services and/or Software.

 

(l) Language. This Agreement is entered into solely in the English language, and if for any reason any other language version is prepared by any party, it shall be solely for convenience and shall have no force or effect and the English version shall govern and control in all respects. All proceedings related to this Agreement shall be conducted in the English language. If You are located in the province of Quebec, Canada, the following applies: The parties hereby confirm they have requested this Agreement and all related documents be prepared in English. Les parties ont exigé que le présent contrat et tous les documents connexes soient rédigés en anglais.

 

(m) Entire Agreement. Except as set forth below with regard to separately negotiated agreements, this Agreement is the entire and exclusive agreement between PTC and You with respect to the Software, Documentation and the Services, and this Agreement supersedes, and its terms govern, all prior or contemporaneous understandings, representations, letters of intent, memoranda of understanding, agreements, or other communications between the parties, oral or written, regarding such subject matter, including, without limitation all prior online click-to-accept agreements with respect to all or any part of the Software or Services (e.g., the License Agreement for Vuforia Software Development Kit and the Vuforia Cloud Recognition Services Agreement) (each an “Online Agreement”). For purposes of clarity, the foregoing sentence shall not impact or limit in any manner the terms of a separately negotiated agreement executed by the parties with respect to the Software, Documentation and Services that by its express terms was intended to supersede all or part of the applicable Online Agreement (each a “Negotiated Agreement”). With regard to a reference in a Negotiated Agreement to a specific section in an Online Agreement, the section references in the Negotiated Agreement shall be deemed to refer to sections in the Online Agreement based on section title references, rather than based on section number (e.g., references in a Negotiated Agreement to “Section 1.9 (Additional Software)” of the Online Agreement shall be deemed to be references to the Section titled “Additional Software” herein). In the event of a conflict between this Agreement and the TOU, the Privacy Policy, or the Vuforia Pricing Schedule, this Agreement will control.

 

BY AGREEING TO THESE TERMS YOU REPRESENT, WARRANT AND CERTIFY THAT: YOU ARE AN AUTHORIZED REPRESENTATIVE OF THE LEGAL ENTITY YOU REPRESENT; YOU HAVE READ THIS AGREEMENT AND UNDERSTAND IT; YOU HAVE THE AUTHORITY TO BIND THE LEGAL ENTITY YOU REPRESENT TO THE TERMS AND CONDITIONS OF THIS AGREEMENT, AND YOU AGREE ON BEHALF OF THE LEGAL ENTITY YOU REPRESENT TO BE BOUND BY ITS TERMS AND CONDITIONS.

Exhibit 1

Payment Terms

 

I. FEES. Fees for the Services are set forth in the Vuforia Pricing Schedule and, unless otherwise agreed in writing by PTC, are charged on a per Developer Application basis and are calculated and billed monthly or annually. To initiate the creation of Developer Applications in the Engine Developer Portal, You must select a specific License for each Developer Application. Fees begin accruing as of the date You select a License and have been granted a License Key for such Developer Application. For Licenses with recurring charges, Fees will continue accruing monthly or annually for each Developer Application until You cancel the Services for that particular Developer Application as set forth in Section II (Cancellation) below.

 

II. CANCELLATIONS. You may cancel the License and the associated License Key for one or more Developer Application(s) by providing PTC with notice in accordance with the cancellation instructions provided in the Vuforia Support Center. You will be obligated to pay fees that have accrued through the date of cancellation. Cancellation of the License and License Key for one or more Developer Application(s) will not automatically terminate this Agreement. Cancellation of the License and License Key will terminate Your rights to use the Software and Services with such application. In addition, this Agreement will terminate and You will no longer have any right to use the Software or Services if You have no active Licenses associated with Your account.

 

III. USAGE. If Your License is usage-based, You acknowledge and agree that You are permitted a certain level of usage (e.g., a maximum number of Recognitions or Queries per month, a maximum amount of Cloud Targets, and/or a maximum number of generated VuMark) in accordance with the License applicable to each Developer Application. If Your actual usage of the Services for such Developer Application exceeds such levels, You will pay an overage fee as specified in the Pricing Schedule (or Negotiated Agreement, if applicable) for each Recognition or Query by that Developer Application that exceeds the usage permitted for the applicable License. The overage fee specified in the Pricing Schedule will be made available either directly on the Pricing Schedule or through a mouse-over of an underlined term in the Pricing Schedule (e.g., placing or hovering your pointer or cursor over the underlined term “Cloud Recognition” opens up a box describing the overage fee for each reco that exceeds the maximum usage for the License applicable to the Developer Application) or in some other manner. If you are unable to see these details on the Pricing Schedule, the overage fee for a License will be made available to You after selecting a License from the Pricing Schedule, but before You confirm such License and authorize Your credit card to be charged. Overage fees shall be billed monthly in arrears.

 

IV. BILLING & PAYMENT. You must provide complete and accurate information as reasonably requested by PTC during the account creation and enrollment process and must provide PTC with updates to such information when and as applicable.

 

A. Billing Statement. PTC will provide an electronic billing statement and payment instructions to You on a monthly or annual basis for the applicable fees and amounts due to PTC. You agree to make payment in accordance with the payment instructions. Billing related information will be sent to the email address designated by You during the account creation process as the Billing Contact. Unless otherwise expressly stated, all amounts stated in this Agreement are in U.S. Dollars. The fees for the initial month will be prorated for the calendar month in which the applicable License Key was granted. For payments hereunder, if PTC provides written notice to You requesting You to pay some or all of the amounts due under this Agreement to an entity affiliated with PTC, then You will pay such entity the amounts due under this Agreement.

 

B. Payment Method.

 

1. Recurring Billing. Unless otherwise authorized by PTC, payments must be made via a credit card accepted by PTC with monthly or annual charges paid automatically on a recurring basis (“recurring billing”).

 

a) You hereby authorize PTC to automatically charge Your credit card on a recurring monthly or annual basis for the Fees due. It is Your responsibility to make sure the credit or debit card information on Your account is kept updated. You guarantee and warrant that You are the legal cardholder and that You are legally authorized to enter into this recurring billing agreement with PTC.

 

b) You acknowledge that You may withdraw this authorization for recurring billing at any time by submitting a support request through the Engine Developer Portal (or in any other manner specified by PTC from time to time). PTC will use commercially reasonable efforts to discontinue the recurring billing promptly. If You elect to withdraw Your authorization for recurring billing, PTC may elect to cancel Your License and/or terminate this Agreement upon notice.

 

2. Other Payment Methods. If You cancel recurring billing and/or PTC has authorized payment by a different method, You must deliver payment in accordance with the payment instructions no later than thirty (30) days from the date of the electronic billing statement.

 

3. Wire Transfers. If approved for payment by wire transfer method, wire transfer fees charged by Your financial institution are Your responsibility and shall not be deducted from the invoice balance due to PTC.

 

C. Late Payments. All payments of amounts due to PTC which are not paid when due shall accrue late payment charges on the unpaid amount in the amount of one and one-half percent (1.5%) per month or the maximum amount allowable under applicable law, whichever is less, from the date due until the date paid in full, together with any accrued late payment charges.

 

D. Adjustments. PTC shall have no obligation to provide, and You shall not be entitled to receive, any credits or refunds relating to amounts paid or owed to PTC.

 

E. Foreign Exchange. For any amounts due PTC by You that are denominated in a currency other than U.S. Dollars, PTC will charge You based on the conversion of such amounts from such other currency into U.S. Dollars in the calendar month in which such amounts were generated. The rate of exchange shall be determined using either: (i) the applicable rate as referenced on Reuters (or another source reasonably determined by PTC) at the close of business on the last business day of the calendar month prior to the month in question or (ii) such other conversion method used by PTC’s billing processor.

 

V. TAXES.

 

A. All prices are exclusive of sales tax, withholding tax, value-added tax, duties, and any other taxes or similar levies imposed by any government authority. In the event that any sales, use, consumption, value-added, gross receipts, excise, or similar taxes or surcharges ("transactional tax(es)") are applicable to any of the transactions contemplated by this Agreement, You shall be responsible for payment of such taxes whether concurrently included with the original billed amount or subsequently charged based on a review of the facts affecting Your tax status or a determination that the laws of the applicable state(s) require assessment and collection of tax. You shall be responsible to self-account for any VAT payable to Your local tax authorities according to applicable VAT rules and regulations in the jurisdictions where You are located.

 

B. Notwithstanding the foregoing, if You are required by applicable law to withhold income taxes from any payment due to PTC, then the amount due to PTC in respect to such payment shall be reduced by the amount of such income tax withholding; then You will deliver to PTC an income tax withholding certificate or similar documentation reasonably satisfactory to PTC evidencing payment of any such withholding. Upon receipt by PTC of the income tax withholding certificate, the portion of the amount billed represented by the income tax withholding certificate will be deemed fully paid. If there is an applicable tax treaty, PTC agrees to provide You the necessary documentation in order to have You withhold at the beneficial treaty rate. You agree that upon receipt of the necessary documentation, You will only withhold at the beneficial treaty rate. If You fail to withhold income taxes from any payment due to PTC where income tax withholding is required by applicable law, PTC shall have no obligation to reimburse You for such unwithheld income taxes, unless You request reimbursement from PTC in writing within sixty (60) days after the applicable billing statement date. You shall be responsible for any penalty, additional tax, interest or other charge due.

 

VI. AUDITS.

 

During the term of this Agreement and for eighteen (18) months thereafter, You shall maintain complete and accurate records of its activities under this Agreement, including without limitation those that give rise to payment and reporting obligations. Upon reasonable notice to You by PTC, PTC may audit Your books and records to determine Your compliance with this Agreement, including without limitation the calculation and payment of the amounts due under this Agreement. In all instances where an underpayment is discovered, You shall promptly pay to PTC any such underpayment (plus accrued late payment charges), and without limiting any other rights or remedies to which PTC is entitled, failure to pay all amounts owed shall be grounds for termination in accordance with Section 12 hereof.

















---

