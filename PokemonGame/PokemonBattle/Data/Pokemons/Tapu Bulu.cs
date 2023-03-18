using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tapubulu : Pokemon
	{
		public override string Name => "Tapu Bulu";
		public override List<Ability> AvailableAbilities => new() {new Grassysurge() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(70, 130, 115, 85, 95, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leafage(), new Rocksmash() },
			[5] = new List<Move>() { new Withdraw() },
			[10] = new List<Move>() { new Disable() },
			[15] = new List<Move>() { new Leechseed() },
			[20] = new List<Move>() { new Megadrain() },
			[25] = new List<Move>() { new Whirlwind() },
			[30] = new List<Move>() { new Hornattack() },
			[35] = new List<Move>() { new Scaryface() },
			[40] = new List<Move>() { new Hornleech() },
			[45] = new List<Move>() { new Zenheadbutt() },
			[50] = new List<Move>() { new Meanlook() },
			[55] = new List<Move>() { new Naturesmadness() },
			[60] = new List<Move>() { new Woodhammer() },
			[65] = new List<Move>() { new Megahorn() },
			[70] = new List<Move>() { new Skullbash() },
			[75] = new List<Move>() { new Grassyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulletseed(), new Calmmind(), new Closecombat(), new Darkestlariat(), new Dazzlinggleam(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyterrain(), new Guardswap(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Lightscreen(), new Megahorn(), new Megapunch(), new Payback(), new Powerswap(), new Protect(), new Reflect(), new Rest(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scaryface(), new Seedbomb(), new Sleeptalk(), new Smartstrike(), new Snarl(), new Snore(), new Solarbeam(), new Stoneedge(), new Storedpower(), new Substitute(), new Sunnyday(), new Superpower(), new Swordsdance(), new Taunt(), new Workup(), new Zenheadbutt() };
		public override int Weight => 455;
		public override int ExpYield => 285;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}