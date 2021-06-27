using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void SceneLoader(int SceneName)
    {
        //SceneManager.LoadScene(SceneName);
        StartCoroutine(SceneLoading(SceneName));
    }
    public Animator animator;
    IEnumerator SceneLoading(int Scene)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(Scene);
    }


//housing
    public void SceneLoaderHousingNext()
    {
        if(HousingData.ex_housing_helper==1)
        {
            SceneLoader(7);
        }
        else if(HousingData.ex_housing_helper==2)
        {
            SceneLoader(11);
        }
    }
    public void SceneLoaderHousingReturn()
    {
        if(HousingData.ex_housing_helper==1)
        {
            SceneLoader(7);
        }
        else if(HousingData.ex_housing_helper==2)
        {
            SceneLoader(2);
        }
    }

    //studio
     public void SceneLoaderStudioNext()
    {
        if(HousingData.ex_studio_helper==1)
        {
            SceneLoader(8);
        }
        else if(HousingData.ex_studio_helper==2)
        {
            SceneLoader(12);
        }
    }
    public void SceneLoaderStudioReturn()
    {
        if(HousingData.ex_studio_helper==1)
        {
            SceneLoader(8);
        }
        else if(HousingData.ex_studio_helper==2)
        {
            SceneLoader(3);
        }
    }
    //shop
    public void SceneLoaderShopNext()
    {
        if(HousingData.ex_shop_helper==1)
        {
            SceneLoader(9);//scena2
        }
        else if(HousingData.ex_shop_helper==2)
        {
            SceneLoader(13);//scena3
        }
    }
    public void SceneLoaderShopReturn()
    {
        if(HousingData.ex_shop_helper==1)
        {
            SceneLoader(9);//scena2
        }
        else if(HousingData.ex_shop_helper==2)
        {
            SceneLoader(4);//scena1
        }
    }
    //clotches
    public void SceneLoaderClotchesNext()
    {
        if(HousingData.ex_clotches_helper==1)
        {
            SceneLoader(10);//scena2
        }
        else if(HousingData.ex_clotches_helper==2)
        {
            SceneLoader(14);//scena3
        }
    }
    public void SceneLoaderClotchesReturn()
    {
        if(HousingData.ex_clotches_helper==1)
        {
            SceneLoader(10);//scena2
        }
        else if(HousingData.ex_clotches_helper==2)
        {
            SceneLoader(5);//scena1
        }
    }
}
