using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Delphox : Pokemon
	{
		public override string Name => "Delphox";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(75, 69, 72, 104, 114, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Mysticalfire() },
			[1] = new List<Move>() { new Mysticalfire(), new Futuresight(), new Roleplay(), new Switcheroo(), new Shadowball(), new Scratch(), new Tailwhip(), new Ember(), new Howl() },
			[5] = new List<Move>() { new Ember() },
			[11] = new List<Move>() { new Howl() },
			[14] = new List<Move>() { new Flamecharge() },
			[18] = new List<Move>() { new Psybeam() },
			[22] = new List<Move>() { new Firespin() },
			[28] = new List<Move>() { new Luckychant() },
			[31] = new List<Move>() { new Lightscreen() },
			[38] = new List<Move>() { new Psyshock() },
			[45] = new List<Move>() { new Flamethrower() },
			[51] = new List<Move>() { new Willowisp() },
			[57] = new List<Move>() { new Psychic() },
			[62] = new List<Move>() { new Sunnyday() },
			[68] = new List<Move>() { new Magicroom() },
			[74] = new List<Move>() { new Fireblast() },
			[80] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Blastburn(), new Calmmind(), new Confide(), new Covet(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Embargo(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Foulplay(), new Frustration(), new Gigaimpact(), new Grassknot(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Laserfocus(), new Lightscreen(), new Lowkick(), new Magiccoat(), new Magicroom(), new Overheat(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Rest(), new Return(), new Roleplay(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Telekinesis(), new Thief(), new Thunderpunch(), new Toxic(), new Trick(), new Trickroom(), new Willowisp(), new Wonderroom(), new Workup(), new Zenheadbutt() };
		public override int Weight => 390;
		public override int ExpYield => 267;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}