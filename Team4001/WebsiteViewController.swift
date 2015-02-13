//
//  WebsiteViewController.swift
//  Team4001
//
//  Created by Safwan on 2015-02-12.
//  Copyright (c) 2015 FRC4001. All rights reserved.
//

import UIKit

class WebsiteViewController: UIViewController {
    
    var website = NSURL(string: "http://team4001.com")!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        // Display the current Team 4001 website
        var webView = UIWebView(frame: UIScreen.mainScreen().bounds)
        webView.loadRequest(NSURLRequest(URL: website))
        
        view = webView
    }
    
}