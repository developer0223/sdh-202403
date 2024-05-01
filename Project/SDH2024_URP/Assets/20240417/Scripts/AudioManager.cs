namespace developer0223._20240417
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    using developer0223._20240410;

    using LitJson;

    public class AudioManager : MonoSingleton<AudioManager>
    {
        [SerializeField] private AudioSource bgmSource = null;
        [SerializeField] private AudioSource effectSource = null;

        // Singleton 패턴을 이용해서 구현

        /// <summary>
        /// BGM을 재생하는 함수 2개
        /// </summary>
        /// <param name="clip"></param>
        public void PlayBGM(AudioClip clip)
        {
            if (bgmSource == null)
            {
                //Debug.LogWarning();
                return;
            }
            // AudioClip을 받아서 bgmSource에서 재생
            bgmSource.clip = clip;
            bgmSource.Play();
        }

        public void Callee()
        {
            try
            {
                Test("ttt");
            }
            catch (ABCNotExistException e)
            {
                Debug.Log(e.ToString());
            }
            catch
            {
                Debug.Log("Unknown error");
            }
            
        }

        public void Test(string text)
        {
            // 이 텍스트에 꼭 ABC라는 문자열이 포함되어있어야 함
            // Custom Exception을 만들어서 리턴해줌
            if (!text.Contains("ABC"))
            {
                Debug.LogError("");
                throw new ABCNotExistException();
            }    
        }

        public class ABCNotExistException : System.Exception
        {

        }

        public void PlayBGM(AudioClip clip, float volume)
        {
            // AudioClip을 받아서 bgmSource에서 재생, bgmSource의 volume을 재설정
            // case 1. PlayBGM에 있는 코드들을 똑같이 복붙하여 작성, 그리고 volume에 대한 설정
            bgmSource.volume = volume;
            bgmSource.clip = clip;
            bgmSource.Play();

            // case 2. volume에 대한 재설정 후 PlayBGM(AudioClip) 함수를 실행
            bgmSource.volume = volume;
            PlayBGM(clip);
        }

        // Effect를 재생하는 함수 2개
        public void PlayEffect(AudioClip clip)
        {
            // AudioClip을 받아서 effectSource에서 재생
            // case 1: 직접 구현
            effectSource.clip = clip;
            effectSource.Play();

            // case 2: PlayOneShot 메서드 사용
            effectSource.PlayOneShot(clip);
        }

        public void PlayEffect(AudioClip clip, float volume)
        {
            // AudioClip을 받아서 effectSource에서 재생, bgmSource의 volume을 재설정
            // case 1: 직접 구현
            effectSource.volume = volume;
            effectSource.clip = clip;
            effectSource.Play();

            // case 2: PlayOneShot 메서드 사용
            effectSource.PlayOneShot(clip, volume);
        }
    }
}