using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grumpig : Pokemon
	{
		public override string Name => "Grumpig";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(80, 45, 65, 90, 110, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Teeterdance() },
			[1] = new List<Move>() { new Teeterdance(), new Belch(), new Splash() },
			[7] = new List<Move>() { new Confusion() },
			[10] = new List<Move>() { new Growl() },
			[14] = new List<Move>() { new Psybeam() },
			[15] = new List<Move>() { new Psychup() },
			[18] = new List<Move>() { new Confuseray() },
			[21] = new List<Move>() { new Magiccoat() },
			[26] = new List<Move>() { new Zenheadbutt() },
			[29] = new List<Move>() { new Powergem() },
			[35] = new List<Move>() { new Rest(), new Snore() },
			[42] = new List<Move>() { new Psyshock() },
			[46] = new List<Move>() { new Payback() },
			[52] = new List<Move>() { new Psychic() },
			[60] = new List<Move>() { new Bounce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bounce(), new Brickbreak(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Confide(), new Covet(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Endure(), new Energyball(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Healbell(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Icywind(), new Irontail(), new Laserfocus(), new Lightscreen(), new Magiccoat(), new Nastyplot(), new Payback(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Roleplay(), new Round(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Thunderpunch(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Zenheadbutt() };
		public override int Weight => 715;
		public override int ExpYield => 165;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}